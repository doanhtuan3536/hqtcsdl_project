USE QLNHAKHOA
GO
--EXEC Sp_NV_LAYTHONGTINTK 'anhtuan', '123'
DECLARE @LoaiAcc INT;
DECLARE @Ma VARCHAR(10);
DECLARE @MaTK VARCHAR(10);
DECLARE @Trangthai VARCHAR(10);
EXEC Sp_DangNhap '789456123', 'pass123', @LoaiAcc OUTPUT, @Ma OUTPUT, @MaTK OUTPUT, @Trangthai OUTPUT;
print(@Ma)

	