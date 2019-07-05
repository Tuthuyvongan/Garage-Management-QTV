ALTER TABLE PhieuTiepNhan
ADD CONSTRAINT fk_PhieuTiepNhan_HieuXe
FOREIGN KEY (hieuxe)
REFERENCES HieuXe (hieuxe);