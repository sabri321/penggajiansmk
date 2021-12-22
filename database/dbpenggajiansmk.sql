-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 22, 2021 at 04:46 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbpenggajiansmk`
--

-- --------------------------------------------------------

--
-- Table structure for table `absensi`
--

CREATE TABLE `absensi` (
  `nip` int(30) NOT NULL,
  `namaguru` varchar(50) NOT NULL,
  `jabatan` varchar(30) NOT NULL,
  `bulan` varchar(30) NOT NULL,
  `jumlahjamperbulan` int(30) NOT NULL,
  `jumlahjamtidakterisi` int(30) NOT NULL,
  `jumlahjamterisi` int(30) NOT NULL,
  `honor` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `absensi`
--

INSERT INTO `absensi` (`nip`, `namaguru`, `jabatan`, `bulan`, `jumlahjamperbulan`, `jumlahjamtidakterisi`, `jumlahjamterisi`, `honor`) VALUES
(1997020102, 'Rozi', 'KTU', 'Desember', 20, 3, 17, 340000),
(1998082101, 'Muhammad Sabri', 'Kajur RPL', 'Desember', 20, 2, 18, 360000);

-- --------------------------------------------------------

--
-- Table structure for table `bank`
--

CREATE TABLE `bank` (
  `kodebank` varchar(10) NOT NULL,
  `nip` int(30) NOT NULL,
  `namaguru` varchar(50) NOT NULL,
  `namabank` varchar(30) NOT NULL,
  `norekening` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bank`
--

INSERT INTO `bank` (`kodebank`, `nip`, `namaguru`, `namabank`, `norekening`) VALUES
('KBNK0001', 1998082101, 'Muhammad Sabri', 'Mandiri', 2147483647),
('KBNK0002', 1997020102, 'Rozi', 'BNI', 2147483647);

-- --------------------------------------------------------

--
-- Table structure for table `guru`
--

CREATE TABLE `guru` (
  `nip` int(30) NOT NULL,
  `namaguru` varchar(50) NOT NULL,
  `jabatan` varchar(30) NOT NULL,
  `tempatlahir` varchar(30) NOT NULL,
  `tanggallahir` date NOT NULL,
  `jeniskelamin` varchar(15) NOT NULL,
  `agama` varchar(20) NOT NULL,
  `pendidikan` varchar(20) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `notelp` varchar(15) NOT NULL,
  `email` varchar(30) NOT NULL,
  `status` varchar(30) NOT NULL,
  `tahunmasuk` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `guru`
--

INSERT INTO `guru` (`nip`, `namaguru`, `jabatan`, `tempatlahir`, `tanggallahir`, `jeniskelamin`, `agama`, `pendidikan`, `alamat`, `notelp`, `email`, `status`, `tahunmasuk`) VALUES
(1997020102, 'Rozi', 'KTU', 'Tanjung', '1999-03-03', 'Laki-Laki', 'Islam', 'S1', 'Jl. Mekar Sari Tanjung ', '087656577673', 'roziununtb@gmail.com', 'Belum Menikah', 2010),
(1998082101, 'Muhammad Sabri', 'Kajur RPL', 'Nyiur Gading', '1998-08-21', 'Laki-Laki', 'Islam', 'S1', 'Jl. Kali Babak Kr. Bedil Utara', '087863657356', 'sabrietihad@gmail.com', 'Belum Menikah', 2010);

-- --------------------------------------------------------

--
-- Table structure for table `sekolah`
--

CREATE TABLE `sekolah` (
  `npsn` varchar(10) NOT NULL,
  `namakepalasekolah` varchar(50) NOT NULL,
  `bendahara` varchar(50) NOT NULL,
  `namasekolah` varchar(50) NOT NULL,
  `alamatsekolah` varchar(100) NOT NULL,
  `kecamatan` varchar(50) NOT NULL,
  `provinsi` varchar(50) NOT NULL,
  `website` varchar(50) NOT NULL,
  `emailsekolah` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sekolah`
--

INSERT INTO `sekolah` (`npsn`, `namakepalasekolah`, `bendahara`, `namasekolah`, `alamatsekolah`, `kecamatan`, `provinsi`, `website`, `emailsekolah`) VALUES
('50200387', 'Kadafi, M.Kom', 'Siswandi, S.Kom', 'SMK YUSUF ABDUSSATAR', 'Jl. Kali Babak RT.10. Kr. Bedil Kediri Lobar NTB 83362 Telp. 672280', 'KEDIRI', 'NUSA TENGGARA BARAT', 'http://www.smkyusufabdussatar.com', 'smkyusufabdussatar@ymail.com');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `kodetransaksi` varchar(10) NOT NULL,
  `nip` int(30) NOT NULL,
  `namaguru` varchar(50) NOT NULL,
  `tanggal` date NOT NULL,
  `jabatan` varchar(30) NOT NULL,
  `gajipokok` int(30) NOT NULL,
  `tunjanganjabatan` int(30) NOT NULL,
  `transport` int(30) NOT NULL,
  `jumlahjamterisi` int(30) NOT NULL,
  `honor` int(30) NOT NULL,
  `honorbersih` int(30) NOT NULL,
  `jenis` varchar(30) NOT NULL,
  `metode` varchar(30) NOT NULL,
  `namabank` varchar(30) NOT NULL,
  `norekening` int(30) NOT NULL,
  `bulan` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`kodetransaksi`, `nip`, `namaguru`, `tanggal`, `jabatan`, `gajipokok`, `tunjanganjabatan`, `transport`, `jumlahjamterisi`, `honor`, `honorbersih`, `jenis`, `metode`, `namabank`, `norekening`, `bulan`) VALUES
('KTRN0002', 1998082101, 'Muhammad Sabri', '2021-12-01', 'Kajur RPL', 700000, 500000, 100000, 18, 360000, 1660000, 'Honorer', 'Cash', 'Mandiri', 2147483647, 'Desember'),
('KTRN0003', 1997020102, 'Rozi', '2021-11-14', 'KTU', 450000, 200000, 100000, 17, 340000, 1090000, 'Honorer', 'Transfer', 'BNI', 2147483647, 'Desember');

-- --------------------------------------------------------

--
-- Table structure for table `tunjangan`
--

CREATE TABLE `tunjangan` (
  `kodetunjangan` varchar(10) NOT NULL,
  `nip` int(30) NOT NULL,
  `namaguru` varchar(50) NOT NULL,
  `jabatan` varchar(30) NOT NULL,
  `tunjanganjabatan` int(30) NOT NULL,
  `transport` int(30) NOT NULL,
  `gajipokok` int(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tunjangan`
--

INSERT INTO `tunjangan` (`kodetunjangan`, `nip`, `namaguru`, `jabatan`, `tunjanganjabatan`, `transport`, `gajipokok`) VALUES
('KTJN0001', 1998082101, 'Muhammad Sabri', 'Kajur RPL', 500000, 100000, 700000),
('KTJN0002', 1997020102, 'Rozi', 'KTU', 200000, 100000, 450000);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `kodeuser` varchar(10) NOT NULL,
  `namauser` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`kodeuser`, `namauser`, `username`, `password`) VALUES
('USR0001', 'sabri', 'sabri', 'sabri123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `absensi`
--
ALTER TABLE `absensi`
  ADD PRIMARY KEY (`nip`);

--
-- Indexes for table `bank`
--
ALTER TABLE `bank`
  ADD PRIMARY KEY (`kodebank`);

--
-- Indexes for table `guru`
--
ALTER TABLE `guru`
  ADD PRIMARY KEY (`nip`);

--
-- Indexes for table `sekolah`
--
ALTER TABLE `sekolah`
  ADD PRIMARY KEY (`npsn`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`kodetransaksi`);

--
-- Indexes for table `tunjangan`
--
ALTER TABLE `tunjangan`
  ADD PRIMARY KEY (`kodetunjangan`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`kodeuser`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
