-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th10 26, 2023 lúc 10:20 AM
-- Phiên bản máy phục vụ: 10.4.28-MariaDB
-- Phiên bản PHP: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `sieuthimini`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chi_tiet_don_nhap_hang`
--

CREATE TABLE `chi_tiet_don_nhap_hang` (
  `ma_don_nh` int(11) NOT NULL,
  `ma_san_pham` int(11) NOT NULL,
  `ten_san_pham` varchar(100) NOT NULL,
  `so_luong` int(11) NOT NULL,
  `gia` int(100) NOT NULL,
  `thanh_tien` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `chi_tiet_don_nhap_hang`
--

INSERT INTO `chi_tiet_don_nhap_hang` (`ma_don_nh`, `ma_san_pham`, `ten_san_pham`, `so_luong`, `gia`, `thanh_tien`) VALUES
(1, 1, 'Mì gói 3 miền', 200, 2000, 400000),
(1, 3, 'Phở gói Đệ Nhất', 100, 3000, 300000),
(1, 11, 'Mì trộn Kool', 100, 3500, 350000),
(1, 12, 'Hủ tiếu nam vang gói', 150, 3500, 525000),
(2, 2, 'Pepsi', 150, 5000, 750000),
(2, 9, 'Coca cola', 200, 5000, 1000000),
(2, 10, '7Up', 200, 5000, 1000000),
(2, 39, 'Fanta nước cam', 100, 5000, 500000),
(2, 40, 'Fanta Soda kem', 100, 5000, 500000),
(2, 41, 'Fanta việt quất', 100, 5000, 500000),
(2, 42, 'Fanta Nho', 100, 5000, 500000),
(2, 43, 'Fanta dâu tây', 100, 5000, 500000),
(2, 44, 'Nước điện giải Revive', 70, 4000, 280000),
(2, 45, 'Nước điện giải Revive chanh muối', 70, 4000, 280000),
(2, 46, 'Nước điện giải Pocari Sweat', 70, 2000, 140000),
(2, 47, 'Nước điện giải Aquarius', 70, 2000, 140000),
(2, 48, 'Nước điện giải Gatorade', 70, 5000, 350000),
(3, 4, 'Kem đánh răng Colgate', 50, 10000, 500000),
(3, 5, 'Khăn giấy bịch nhỏ', 200, 1000, 200000),
(3, 6, 'Giấy cuộn', 200, 2000, 400000),
(3, 7, 'Kem đánh răng Sensitive', 50, 15000, 750000),
(3, 8, 'Kem đánh răng PS', 50, 12000, 600000),
(3, 14, 'Xà bông Coast', 50, 5000, 250000),
(3, 15, 'Xà bông Safeguard', 50, 5000, 250000),
(3, 16, 'Xà bông Camay', 50, 6000, 300000),
(3, 17, 'Dầu gội đầu Clear', 80, 45000, 3600000),
(3, 18, 'Dầu gội đầu Clear Men', 80, 45000, 3600000),
(3, 19, 'Dầu gội đầu Sunsilk', 80, 40000, 3200000),
(3, 20, 'Dầu gội đầu Dove', 80, 50000, 4000000),
(3, 21, 'Dầu gội đầu Xmen', 80, 45000, 3600000),
(3, 22, 'Dầu gội đầu Selsun', 80, 30000, 2400000),
(3, 37, 'Lốc 10 bịch khăn giấy nhỏ', 50, 10000, 500000),
(3, 38, 'Lốc 10 cuộn giấy', 50, 12000, 600000),
(4, 23, 'Bánh bao trứng cút bịch 4 cái', 40, 12000, 480000),
(4, 24, 'Bánh bao trứng muối bịch 4 cái', 40, 15000, 600000),
(4, 25, 'Bánh bao xá xíu bịch 4 cái', 40, 15000, 600000),
(4, 26, 'Bánh bao cải muối bịch 4 cái', 40, 10000, 400000),
(4, 27, 'Bánh Oishi Indo Chips vị tôm', 100, 3500, 350000),
(4, 28, 'Bánh Oishi Indo Chips vị mực', 100, 3500, 350000),
(4, 29, 'Bánh Oishi Indo Chips vị tôm siêu cay', 100, 3500, 350000),
(4, 30, 'Bánh Ostar vị khoai tây', 100, 5000, 500000),
(4, 31, 'Bánh Ostar vị rong biển', 100, 5000, 500000),
(4, 32, 'Bánh Ostar vị bò BBQ', 100, 5000, 500000),
(4, 33, 'Bánh Toonies vị phô mai', 80, 6000, 480000),
(4, 34, 'Bánh Toonies vị cay', 80, 6000, 480000),
(4, 35, 'Bánh Toonies vị gà', 80, 6000, 480000),
(4, 36, 'Bánh Toonies vị Chocolate', 80, 6000, 480000),
(5, 49, 'Sữa hộp 1L TH True Milk có đường', 50, 25000, 1250000),
(5, 50, 'Sữa hộp 1L TH True Milk ít đường', 50, 25000, 1250000),
(5, 51, 'Sữa hộp 1L Fami có đường', 50, 10000, 500000),
(5, 52, 'Sữa hộp 1L Fami ít đường', 50, 10000, 500000),
(5, 53, 'Sữa hộp 1L Promess nguyên kem', 50, 20000, 1000000),
(5, 54, 'Sữa hộp 1L Promess ít béo', 50, 20000, 1000000),
(5, 55, 'Sữa hộp 1L Promess tách béo', 50, 20000, 1000000),
(5, 56, 'Sữa hộp 1L Mlekovita nguyên kem', 70, 15000, 1050000),
(5, 57, 'Sữa hộp 1L Mlekovita không đường', 70, 15000, 1050000),
(5, 58, 'Sữa gạo hộp 1L Woongjin', 70, 20000, 1400000),
(5, 59, 'Sữa gạo lứt đen hộp 1L Woongjin', 70, 20000, 1400000),
(6, 60, 'Dầu ăn Simply', 60, 25000, 1500000),
(6, 61, 'Dầu ăn Tường An', 60, 15000, 900000),
(6, 62, 'Dầu ăn Happi Koki', 60, 10000, 600000),
(6, 63, 'Nước tương Tam thái tử', 60, 5000, 300000),
(6, 64, 'Nước tương Chinsu', 60, 5000, 300000),
(6, 65, 'Nước tương Maggi', 60, 5000, 300000),
(6, 66, 'Nước mắm Chinsu', 60, 5000, 300000),
(6, 67, 'Nước mắm Nam ngư', 60, 5000, 300000),
(6, 68, 'Tương ớt Chinsu', 60, 5000, 300000),
(6, 69, 'Tương ớt Knol', 60, 5000, 300000),
(6, 70, 'Tương ớt Cholimex', 60, 5000, 300000),
(6, 71, 'Tương cà Cholimex', 60, 5000, 300000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `chi_tiet_hoa_don`
--

CREATE TABLE `chi_tiet_hoa_don` (
  `ma_hoa_don` int(11) NOT NULL,
  `ma_san_pham` int(11) NOT NULL,
  `ten_san_pham` varchar(100) NOT NULL,
  `so_luong` int(11) NOT NULL,
  `gia_san_pham` int(100) NOT NULL,
  `thanh_tien` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `chi_tiet_hoa_don`
--

INSERT INTO `chi_tiet_hoa_don` (`ma_hoa_don`, `ma_san_pham`, `ten_san_pham`, `so_luong`, `gia_san_pham`, `thanh_tien`) VALUES
(1, 1, 'Mì gói 3 miền', 2, 5000, 10000),
(1, 2, 'Pepsi', 2, 10000, 20000);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `don_nhap_hang`
--

CREATE TABLE `don_nhap_hang` (
  `ma_don_nh` int(11) NOT NULL,
  `ma_ncc` int(11) NOT NULL,
  `ma_nhan_vien` int(10) NOT NULL,
  `ngay_nhap` date NOT NULL,
  `tong_tien_nhap` int(100) NOT NULL,
  `trang_thai` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `don_nhap_hang`
--

INSERT INTO `don_nhap_hang` (`ma_don_nh`, `ma_ncc`, `ma_nhan_vien`, `ngay_nhap`, `tong_tien_nhap`, `trang_thai`) VALUES
(1, 2, 4, '2023-10-15', 1575000, 1),
(2, 1, 4, '2023-10-15', 6440000, 1),
(3, 4, 4, '2023-10-15', 24750000, 1),
(4, 3, 4, '2023-10-15', 6200000, 1),
(5, 5, 4, '2023-10-15', 11400000, 1),
(6, 6, 4, '2023-10-15', 6500000, 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `hoa_don`
--

CREATE TABLE `hoa_don` (
  `ma_hoa_don` int(11) NOT NULL,
  `ngay_xuat` date NOT NULL,
  `ma_nhan_vien` int(10) NOT NULL,
  `tong_tien` int(100) NOT NULL,
  `trang_thai` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `hoa_don`
--

INSERT INTO `hoa_don` (`ma_hoa_don`, `ngay_xuat`, `ma_nhan_vien`, `tong_tien`, `trang_thai`) VALUES
(1, '2023-10-15', 2, 30000, 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `loai_san_pham`
--

CREATE TABLE `loai_san_pham` (
  `ma_loai` int(11) NOT NULL,
  `ten_loai` varchar(50) NOT NULL,
  `ma_ncc` int(10) NOT NULL,
  `trang_thai` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `loai_san_pham`
--

INSERT INTO `loai_san_pham` (`ma_loai`, `ten_loai`, `ma_ncc`, `trang_thai`) VALUES
(1, 'Mì gói', 2, 1),
(2, 'Nước uống', 1, 1),
(3, 'Kem đánh răng', 4, 1),
(4, 'Khăn giấy', 4, 1),
(5, 'Xà phòng', 4, 1),
(6, 'Snack', 3, 1),
(7, 'Bánh bao', 3, 1),
(8, 'Sữa', 5, 1),
(9, 'Dầu ăn', 6, 1),
(10, 'Nước tương', 6, 1),
(11, 'Nước mắm', 6, 1),
(12, 'Tương', 6, 1),
(16, 'm', 1, 0),
(17, 'Thịt', 1, 0),
(18, 'aawdwas', 1, 0),
(19, 'dawd', 1, 0),
(20, 'wddw', 1, 0),
(21, 'dwadfeer', 1, 0),
(22, 'awddrf', 1, 0);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nhan_vien`
--

CREATE TABLE `nhan_vien` (
  `ma_nhan_vien` int(11) NOT NULL,
  `ten_nhan_vien` varchar(100) NOT NULL,
  `ngay_sinh` date NOT NULL,
  `sdt` varchar(100) NOT NULL,
  `mail` varchar(100) NOT NULL,
  `tai_khoan` int(10) NOT NULL DEFAULT 0,
  `trang_thai` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `nhan_vien`
--

INSERT INTO `nhan_vien` (`ma_nhan_vien`, `ten_nhan_vien`, `ngay_sinh`, `sdt`, `mail`, `tai_khoan`, `trang_thai`) VALUES
(1, 'Duong Van An', '1999-09-04', '0348576297', 'admin@gmail.com', 1, 1),
(2, 'Nguyen Xuan B', '2000-09-03', '0349579286', 'nhanvien1@gmail.com', 3, 1),
(3, 'Tran Thi T', '2002-10-02', '0348576103', 'nhanvien2@gmail.com', 4, 1),
(4, 'Ngo Trung N', '1999-09-04', '0385927452', 'quanly1@gmail.com', 2, 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `nha_cung_cap`
--

CREATE TABLE `nha_cung_cap` (
  `ma_ncc` int(11) NOT NULL,
  `ten_ncc` varchar(100) NOT NULL,
  `dia_chi` varchar(255) NOT NULL,
  `trang_thai` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `nha_cung_cap`
--

INSERT INTO `nha_cung_cap` (`ma_ncc`, `ten_ncc`, `dia_chi`, `trang_thai`) VALUES
(1, 'Nhà cung cấp nước uống', 'TP.HCM', 1),
(2, 'Nhà cung cấp thực phẩm ăn liền', 'Bình Dương', 1),
(3, 'Nhà cung cấp bánh', 'TP.HCM', 1),
(4, 'Nhà cung cấp đồ dùng thiết yếu', 'TP.Thủ Đức', 1),
(5, 'Nhà cung cấp sữa', 'TP.HCM', 1),
(6, 'Nhà cung cấp gia vị', 'Vũng Tàu', 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `phan_quyen`
--

CREATE TABLE `phan_quyen` (
  `ma_quyen` int(11) NOT NULL,
  `ten_quyen` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `phan_quyen`
--

INSERT INTO `phan_quyen` (`ma_quyen`, `ten_quyen`) VALUES
(0, 'null'),
(1, 'admin'),
(2, 'quanly'),
(3, 'nhanvien');

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `san_pham`
--

CREATE TABLE `san_pham` (
  `ma_san_pham` int(10) NOT NULL,
  `ten_san_pham` varchar(100) NOT NULL,
  `so_luong` int(11) NOT NULL,
  `gia` int(100) NOT NULL,
  `gia_nhap` int(100) NOT NULL,
  `ma_loai` int(11) NOT NULL,
  `trang_thai` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `san_pham`
--

INSERT INTO `san_pham` (`ma_san_pham`, `ten_san_pham`, `so_luong`, `gia`, `gia_nhap`, `ma_loai`, `trang_thai`) VALUES
(1, 'Mì gói 3 miền', 198, 5000, 2000, 2, 1),
(2, 'Pepsi', 148, 10000, 5000, 1, 1),
(3, 'Phở gói Đệ Nhất', 100, 8000, 3000, 2, 1),
(4, 'Kem đánh răng Colgate', 50, 25000, 10000, 3, 1),
(5, 'Khăn giấy bịch nhỏ', 200, 3000, 1000, 4, 1),
(6, 'Giấy cuộn', 200, 4000, 2000, 4, 1),
(7, 'Kem đánh răng Sensitive', 50, 30000, 15000, 3, 1),
(8, 'Kem đánh răng PS', 50, 28000, 12000, 3, 1),
(9, 'Coca cola', 200, 10000, 5000, 1, 1),
(10, '7Up', 200, 10000, 5000, 1, 1),
(11, 'Mì trộn Kool', 100, 7000, 3500, 2, 1),
(12, 'Hủ tiếu nam vang gói', 150, 8000, 3500, 2, 1),
(13, 'Xà bông Lifebouy', 50, 12000, 5000, 5, 1),
(14, 'Xà bông Coast', 50, 11000, 5000, 5, 1),
(15, 'Xà bông Safeguard', 50, 10000, 5000, 5, 1),
(16, 'Xà bông Camay', 50, 15000, 6000, 5, 1),
(17, 'Dầu gội đầu Clear', 80, 90000, 45000, 5, 1),
(18, 'Dầu gội đầu Clear Men', 80, 90000, 45000, 5, 1),
(19, 'Dầu gội đầu Sunsilk', 80, 80000, 40000, 5, 1),
(20, 'Dầu gội đầu Dove', 80, 100000, 50000, 5, 1),
(21, 'Dầu gội đầu Xmen', 80, 90000, 45000, 5, 1),
(22, 'Dầu gội đầu Selsun', 80, 70000, 30000, 5, 1),
(23, 'Bánh bao trứng cút bịch 4 cái', 40, 25000, 12000, 7, 1),
(24, 'Bánh bao trứng muối bịch 4 cái', 40, 30000, 15000, 7, 1),
(25, 'Bánh bao xá xíu bịch 4 cái', 40, 30000, 15000, 7, 1),
(26, 'Bánh bao cải muối bịch 4 cái', 40, 20000, 10000, 7, 1),
(27, 'Bánh Oishi Indo Chips vị tôm', 100, 7000, 3500, 6, 1),
(28, 'Bánh Oishi Indo Chips vị mực', 100, 8000, 3500, 6, 1),
(29, 'Bánh Oishi Indo Chips vị tôm siêu cay', 100, 8000, 3500, 6, 1),
(30, 'Bánh Ostar vị khoai tây', 100, 10000, 5000, 6, 1),
(31, 'Bánh Ostar vị rong biển', 100, 12000, 5000, 6, 1),
(32, 'Bánh Ostar vị bò BBQ', 100, 12000, 5000, 6, 1),
(33, 'Bánh Toonies vị phô mai', 80, 12000, 6000, 6, 1),
(34, 'Bánh Toonies vị cay', 80, 12000, 6000, 6, 1),
(35, 'Bánh Toonies vị gà', 80, 12000, 6000, 6, 1),
(36, 'Bánh Toonies vị Chocolate', 80, 12000, 6000, 6, 1),
(37, 'Lốc 10 bịch khăn giấy nhỏ', 50, 20000, 10000, 4, 1),
(38, 'Lốc 10 cuộn giấy', 50, 28000, 12000, 4, 1),
(39, 'Fanta nước cam', 100, 10000, 5000, 1, 1),
(40, 'Fanta Soda kem', 100, 10000, 5000, 1, 1),
(41, 'Fanta việt quất', 100, 10000, 5000, 1, 1),
(42, 'Fanta nho', 100, 10000, 5000, 1, 1),
(43, 'Fanta dâu tây', 100, 10000, 5000, 1, 1),
(44, 'Nước điện giải Revive', 70, 10000, 4000, 1, 1),
(45, 'Nước điện giải Revive chanh muối', 70, 12000, 4000, 1, 1),
(46, 'Nước điện giải Pocari Sweat', 70, 6000, 2000, 1, 1),
(47, 'Nước điện giải Aquarius', 70, 6000, 2000, 1, 1),
(48, 'Nước điện giải Gatorade', 70, 10000, 5000, 1, 1),
(49, 'Sữa hộp 1L TH True Milk có đường', 50, 50000, 25000, 8, 1),
(50, 'Sữa hộp 1L TH True Milk ít đường', 50, 50000, 25000, 8, 1),
(51, 'Sữa hộp 1L Fami có đường', 50, 25000, 10000, 8, 1),
(52, 'Sữa hộp 1L Fami ít đường', 50, 25000, 10000, 8, 1),
(53, 'Sữa hộp 1L Promess nguyên kem', 50, 42000, 20000, 8, 1),
(54, 'Sữa hộp 1L Promess ít béo', 50, 42000, 20000, 8, 1),
(55, 'Sữa hộp 1L Promess tách béo', 50, 42000, 20000, 8, 1),
(56, 'Sữa hộp 1L Mlekovita nguyên kem', 70, 30000, 15000, 8, 1),
(57, 'Sữa hộp 1L Mlekovita không đường', 70, 30000, 15000, 8, 1),
(58, 'Sữa gạo hộp 1L Woongjin', 70, 45000, 20000, 8, 1),
(59, 'Sữa gạo lứt đen hộp 1L Woongjin', 70, 48000, 20000, 8, 1),
(60, 'Dầu ăn Simply', 60, 54000, 25000, 9, 1),
(61, 'Dầu ăn Tường an', 60, 27000, 15000, 9, 1),
(62, 'Dầu ăn Happi Koki', 60, 20000, 10000, 9, 1),
(63, 'Nước tương Tam thái tử', 60, 10000, 5000, 10, 1),
(64, 'Nước tương Chinsu', 60, 15000, 5000, 10, 1),
(65, 'Nước tương Maggi', 60, 15000, 5000, 10, 1),
(66, 'Nước mắm Chinsu', 60, 15000, 5000, 11, 1),
(67, 'Nước mắm Nam ngư', 60, 15000, 5000, 11, 1),
(68, 'Tương ớt Chinsu', 60, 12000, 5000, 12, 1),
(69, 'Tương ớt Knol', 60, 12000, 5000, 12, 1),
(70, 'Tương ớt Cholimex', 60, 12000, 5000, 12, 1),
(71, 'Tương cà Cholimex', 60, 12000, 5000, 12, 1),
(72, 'Tương cà Heinz', 60, 32000, 15000, 12, 1);

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `tai_khoan`
--

CREATE TABLE `tai_khoan` (
  `ma_tai_khoan` int(10) NOT NULL,
  `ten_tai_khoan` varchar(100) NOT NULL,
  `mat_khau` varchar(100) NOT NULL,
  `phan_quyen` int(10) NOT NULL,
  `trang_thai` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Đang đổ dữ liệu cho bảng `tai_khoan`
--

INSERT INTO `tai_khoan` (`ma_tai_khoan`, `ten_tai_khoan`, `mat_khau`, `phan_quyen`, `trang_thai`) VALUES
(0, 'nulll', 'null', 0, 1),
(1, 'admin', '123456', 1, 1),
(2, 'quanly1', '123456', 2, 1),
(3, 'nhanvien1', '123456', 3, 1),
(4, 'nhanvien2', '123456', 3, 1);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `chi_tiet_don_nhap_hang`
--
ALTER TABLE `chi_tiet_don_nhap_hang`
  ADD PRIMARY KEY (`ma_don_nh`,`ma_san_pham`),
  ADD KEY `fk_ctdnh_sp` (`ma_san_pham`);

--
-- Chỉ mục cho bảng `chi_tiet_hoa_don`
--
ALTER TABLE `chi_tiet_hoa_don`
  ADD PRIMARY KEY (`ma_hoa_don`,`ma_san_pham`) USING BTREE,
  ADD KEY `fk_cthd_sp` (`ma_san_pham`);

--
-- Chỉ mục cho bảng `don_nhap_hang`
--
ALTER TABLE `don_nhap_hang`
  ADD PRIMARY KEY (`ma_don_nh`),
  ADD KEY `ma_ncc` (`ma_ncc`),
  ADD KEY `fk_dnh_nv` (`ma_nhan_vien`);

--
-- Chỉ mục cho bảng `hoa_don`
--
ALTER TABLE `hoa_don`
  ADD PRIMARY KEY (`ma_hoa_don`),
  ADD KEY `fk_hd_nv` (`ma_nhan_vien`);

--
-- Chỉ mục cho bảng `loai_san_pham`
--
ALTER TABLE `loai_san_pham`
  ADD PRIMARY KEY (`ma_loai`),
  ADD KEY `ma_ncc` (`ma_ncc`) USING BTREE;

--
-- Chỉ mục cho bảng `nhan_vien`
--
ALTER TABLE `nhan_vien`
  ADD PRIMARY KEY (`ma_nhan_vien`),
  ADD KEY `fk_tk_nv` (`tai_khoan`);

--
-- Chỉ mục cho bảng `nha_cung_cap`
--
ALTER TABLE `nha_cung_cap`
  ADD PRIMARY KEY (`ma_ncc`),
  ADD UNIQUE KEY `ma_ncc` (`ma_ncc`);

--
-- Chỉ mục cho bảng `phan_quyen`
--
ALTER TABLE `phan_quyen`
  ADD PRIMARY KEY (`ma_quyen`);

--
-- Chỉ mục cho bảng `san_pham`
--
ALTER TABLE `san_pham`
  ADD PRIMARY KEY (`ma_san_pham`),
  ADD KEY `ma_loai` (`ma_loai`) USING BTREE;

--
-- Chỉ mục cho bảng `tai_khoan`
--
ALTER TABLE `tai_khoan`
  ADD PRIMARY KEY (`ma_tai_khoan`),
  ADD KEY `fk_taikhoan_phanquyen` (`phan_quyen`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `chi_tiet_hoa_don`
--
ALTER TABLE `chi_tiet_hoa_don`
  MODIFY `ma_hoa_don` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT cho bảng `don_nhap_hang`
--
ALTER TABLE `don_nhap_hang`
  MODIFY `ma_don_nh` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT cho bảng `hoa_don`
--
ALTER TABLE `hoa_don`
  MODIFY `ma_hoa_don` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT cho bảng `loai_san_pham`
--
ALTER TABLE `loai_san_pham`
  MODIFY `ma_loai` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT cho bảng `nhan_vien`
--
ALTER TABLE `nhan_vien`
  MODIFY `ma_nhan_vien` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT cho bảng `nha_cung_cap`
--
ALTER TABLE `nha_cung_cap`
  MODIFY `ma_ncc` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT cho bảng `phan_quyen`
--
ALTER TABLE `phan_quyen`
  MODIFY `ma_quyen` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT cho bảng `san_pham`
--
ALTER TABLE `san_pham`
  MODIFY `ma_san_pham` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=73;

--
-- AUTO_INCREMENT cho bảng `tai_khoan`
--
ALTER TABLE `tai_khoan`
  MODIFY `ma_tai_khoan` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Các ràng buộc cho các bảng đã đổ
--

--
-- Các ràng buộc cho bảng `chi_tiet_don_nhap_hang`
--
ALTER TABLE `chi_tiet_don_nhap_hang`
  ADD CONSTRAINT `fk_ctdnh_dnh` FOREIGN KEY (`ma_don_nh`) REFERENCES `don_nhap_hang` (`ma_don_nh`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_ctdnh_sp` FOREIGN KEY (`ma_san_pham`) REFERENCES `san_pham` (`ma_san_pham`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `chi_tiet_hoa_don`
--
ALTER TABLE `chi_tiet_hoa_don`
  ADD CONSTRAINT `fk_cthd_hd` FOREIGN KEY (`ma_hoa_don`) REFERENCES `hoa_don` (`ma_hoa_don`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_cthd_sp` FOREIGN KEY (`ma_san_pham`) REFERENCES `san_pham` (`ma_san_pham`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `don_nhap_hang`
--
ALTER TABLE `don_nhap_hang`
  ADD CONSTRAINT `fk_dnh_ncc` FOREIGN KEY (`ma_ncc`) REFERENCES `nha_cung_cap` (`ma_ncc`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_dnh_nv` FOREIGN KEY (`ma_nhan_vien`) REFERENCES `nhan_vien` (`ma_nhan_vien`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `hoa_don`
--
ALTER TABLE `hoa_don`
  ADD CONSTRAINT `fk_hd_nv` FOREIGN KEY (`ma_nhan_vien`) REFERENCES `nhan_vien` (`ma_nhan_vien`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `loai_san_pham`
--
ALTER TABLE `loai_san_pham`
  ADD CONSTRAINT `fk_loai_sp_ncc` FOREIGN KEY (`ma_ncc`) REFERENCES `nha_cung_cap` (`ma_ncc`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `nhan_vien`
--
ALTER TABLE `nhan_vien`
  ADD CONSTRAINT `fk_nv_tk` FOREIGN KEY (`tai_khoan`) REFERENCES `tai_khoan` (`ma_tai_khoan`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `san_pham`
--
ALTER TABLE `san_pham`
  ADD CONSTRAINT `fk_sp_loaisp` FOREIGN KEY (`ma_loai`) REFERENCES `loai_san_pham` (`ma_loai`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Các ràng buộc cho bảng `tai_khoan`
--
ALTER TABLE `tai_khoan`
  ADD CONSTRAINT `fk_taikhoan_phanquyen` FOREIGN KEY (`phan_quyen`) REFERENCES `phan_quyen` (`ma_quyen`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
