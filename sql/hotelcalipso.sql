-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 22, 2021 at 05:59 AM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 7.4.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelcalipso`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `rollname` varchar(20) NOT NULL,
  `username` varchar(30) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `rollname`, `username`, `email`, `password`) VALUES
(1, 'USER', 'hjghj', 'hgjhgj', '123'),
(2, 'USER', 'dsf', 'fsd', '456'),
(3, 'USER', 'fsdafdsaf', 'fdsagdasga', '1111'),
(4, 'ADMIN', 'sachintha', 'sachintha@gmail.com', 'madhawa');

-- --------------------------------------------------------

--
-- Table structure for table `roombo0king`
--

CREATE TABLE `roombo0king` (
  `bookid` int(11) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `city` varchar(100) NOT NULL,
  `mobile` int(11) NOT NULL,
  `roomtype` varchar(100) NOT NULL,
  `bedtype` varchar(100) NOT NULL,
  `nofroom` int(11) NOT NULL,
  `mealplan` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `roombo0king`
--

INSERT INTO `roombo0king` (`bookid`, `firstname`, `lastname`, `email`, `city`, `mobile`, `roomtype`, `bedtype`, `nofroom`, `mealplan`) VALUES
(1, 'fsdfs', 'fsdafsad', 'fsadfas', 'fsdafdsa', 788538399, 'Type 1', 'Type 2', 4, 'Type 3');

-- --------------------------------------------------------

--
-- Table structure for table `travel_package`
--

CREATE TABLE `travel_package` (
  `travelId` int(11) NOT NULL,
  `fullname` varchar(100) NOT NULL,
  `nic` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `nationality` varchar(100) NOT NULL,
  `mobile` int(11) NOT NULL,
  `typeOfplace` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `roombo0king`
--
ALTER TABLE `roombo0king`
  ADD PRIMARY KEY (`bookid`);

--
-- Indexes for table `travel_package`
--
ALTER TABLE `travel_package`
  ADD PRIMARY KEY (`travelId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `roombo0king`
--
ALTER TABLE `roombo0king`
  MODIFY `bookid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `travel_package`
--
ALTER TABLE `travel_package`
  MODIFY `travelId` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
