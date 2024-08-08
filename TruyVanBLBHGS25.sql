Use QLBHGS25

create view PhieuThanhToan
AS
SELECT HD.MAHD, NV.MANV, KH.MAKH, SP.MASP, SP.TENSP, CTHD.SOLUONG, SP.GIABAN, (SOLUONG*GIABAN) AS N'THÀNH TIỀN' FROM HOADON AS HD 
JOIN NHANVIEN AS NV ON NV.MANV=HD.MANV
JOIN KHACHHANG AS KH ON KH.MAKH=HD.MAKH 
JOIN CTHD ON CTHD.MAHD=HD.MAHD
JOIN SANPHAM AS SP ON SP.MASP=CTHD.MASP

SELECT * FROM PHIEUTHANHTOAN


create view qlnhaphang
as
select pn.mapn, pn.manv,pn.mancc, ctpn.masp, sp.tensp, ctpn.soluong,  pn.ngaynhap, sp.gianhap, (gianhap*soluong) as N'Thành tiền'
from phieunhap as pn 
join ctpn on ctpn.mapn=pn.mapn
join sanpham as sp on sp.masp=ctpn.masp
join nhanvien as nv on nv.manv=pn.manv

select * from qlnhaphang