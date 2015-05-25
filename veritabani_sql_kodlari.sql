-- Table: ayarlar
CREATE TABLE ayarlar (
	ayarlar_id INTEGER PRIMARY KEY AUTOINCREMENT,
	kutuphane_adi VARCHAR,
	e_posta VARCHAR (40),
	kullanici_a VARCHAR,
	sifre VARCHAR,
	gizli_soru VARCHAR,
	gizli_cevap VARCHAR,
	ceza_miktari VARCHAR,
	ceza_turu VARCHAR
);

-- Table: kitaplar
CREATE TABLE kitaplar (
	kitap_id INTEGER PRIMARY KEY AUTOINCREMENT,
	yazar_id INTEGER,
	yayine_id INTEGER,
	kategori_id INTEGER,
	kitap_adi VARCHAR,
	isbn INTEGER,
	basim_tarihi VARCHAR,
	resim VARCHAR,
	kitap_durumu INTEGER (1),
	FOREIGN KEY (yazar_id) REFERENCES yazarlar (yazar_id),
	FOREIGN KEY (yayine_id) REFERENCES yayin_evi (yayine_id),
	FOREIGN KEY (kategori_id) REFERENCES kategori (kategori_id)
);

-- Table: uyeler
CREATE TABLE uyeler (
	uye_id INTEGER PRIMARY KEY AUTOINCREMENT,
	uye_adi VARCHAR,
	uye_soyadi VARCHAR,
	uye_tc_no INTEGER,
	uye_telefon VARCHAR,
	uye_e_posta VARCHAR,
	uye_adres VARCHAR
);

-- Table: odunc
CREATE TABLE odunc (
	odunc_id INTEGER PRIMARY KEY AUTOINCREMENT,
	uye_id INTEGER,
	kitap_id INTEGER,
	alim_tarihi VARCHAR,
	verecegi_tarihi VARCHAR,
	teslim_edildimi INTEGER (1),
	ceza_durumu VARCHAR,
	FOREIGN KEY (kitap_id) REFERENCES yayin_evi,
	FOREIGN KEY (uye_id) REFERENCES uyeler (uye_id)
);

-- Table: kategori
CREATE TABLE kategori (
	kategori_id INTEGER PRIMARY KEY AUTOINCREMENT,
	kategori_adi VARCHAR
);

-- Table: ceza
CREATE TABLE ceza (
	ceza_id INTEGER PRIMARY KEY AUTOINCREMENT,
	kitap_id INTEGER,
	uye_id INTEGER,
	ceza_miktari VARCHAR,
	ceza_durumu INTEGER (1),
	odunc_id INTEGER REFERENCES odunc (odunc_id),
	FOREIGN KEY (kitap_id) REFERENCES yayin_evi,
	FOREIGN KEY (uye_id) REFERENCES uyeler (uye_id)
);

-- Table: yazarlar
CREATE TABLE yazarlar (
	yazar_id INTEGER PRIMARY KEY AUTOINCREMENT,
	yazar_adi VARCHAR,
	yazar_soyadi VARCHAR
);

-- Table: yayin_evi
CREATE TABLE yayin_evi (
	yayine_id INTEGER PRIMARY KEY AUTOINCREMENT,
	yayine_adi VARCHAR,
	yayine_telefon VARCHAR,
	yayine_adres VARCHAR,
	yayine_eposta VARCHAR
);