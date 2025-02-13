-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Feb 13. 17:00
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `user`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `data`
--

CREATE TABLE `data` (
  `ID` int(11) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Password` varchar(36) NOT NULL,
  `CreatedTime` datetime NOT NULL DEFAULT current_timestamp(),
  `UpdatedTime` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- A tábla adatainak kiíratása `data`
--

INSERT INTO `data` (`ID`, `FirstName`, `LastName`, `Password`, `CreatedTime`, `UpdatedTime`) VALUES
(2, 'Maddy', 'Hovel', 'pQ2%5p5/P*mU_', '2024-10-09 22:10:16', '2024-12-20 09:45:32'),
(3, 'Brittney', 'Phizacklea', 'lC2$7$POz', '2024-02-21 20:37:31', '2024-12-20 09:45:32'),
(4, 'Colene', 'Bard', 'uD6.k%_T`oE', '2024-07-26 04:42:04', '2024-12-20 09:45:32'),
(5, 'Cam', 'Shoebottom', 'dI0%\\__y/AA2~', '2024-03-03 23:09:27', '2024-12-20 09:45:32'),
(6, 'Bertrand', 'Wardale', 'uS6_tF{wYqegoE~', '2024-05-18 01:49:29', '2024-12-20 09:45:32'),
(7, 'Dalila', 'Hampe', 'bB2)i_c,0`#o', '2024-11-25 14:13:03', '2024-12-20 09:45:32'),
(8, 'Raff', 'Addinall', 'zP8$1py$vRrDn', '2024-03-14 20:13:51', '2024-12-20 09:45:32'),
(9, 'Tannie', 'Lembke', 'hB8puV>|ds*', '2023-12-26 10:17:47', '2024-12-20 09:45:32'),
(10, 'Tamra', 'Axelbey', 'gC4#`VKb4i6V', '2024-05-05 02:15:16', '2024-12-20 09:45:32'),
(11, 'Eduino', 'Habergham', 'uH6%bs`<@', '2024-12-06 20:36:38', '2024-12-20 09:45:32'),
(12, 'Harcourt', 'Spencers', 'fW8{CGV$=j8', '2024-05-27 06:52:51', '2024-12-20 09:45:32'),
(13, 'Goddart', 'Starrs', 'iG7\"%ETRut', '2024-03-16 01:38:57', '2024-12-20 09:45:32'),
(14, 'Adelind', 'Tokley', 'kD5@6#X6jzn_$q>', '2024-05-12 13:39:05', '2024-12-20 09:45:32'),
(15, 'fw', 'wf', 'sgí gs ', '2024-03-29 20:00:06', '2024-12-20 09:45:32'),
(16, 'Richart', 'De Filippis', 'aN5+7<=AZ4', '2024-07-31 06:05:57', '2024-12-20 09:45:32'),
(17, 'Albert', 'Chantrell', 'nP4hEa4,qtk', '2024-11-03 05:28:02', '2024-12-20 09:45:32'),
(18, 'Denna', 'Callway', 'kE2`rIXY#\'', '2024-12-11 07:05:26', '2024-12-20 09:45:32'),
(19, 'Adel', 'Gornar', 'wA6,v/_KDuNi5lm', '2024-12-02 16:06:09', '2024-12-20 09:45:32'),
(20, 'Mirabel', 'Braemer', 'bB7*4@wJ', '2024-08-10 20:33:59', '2024-12-20 09:45:32'),
(22, 'asdasd', 'asdasd', 'asdasd123', '0000-00-00 00:00:00', '2025-01-10 11:21:44'),
(23, '', 'ggffdf', 'ggfgff', '2025-01-10 12:10:38', '2025-01-10 12:10:38'),
(25, 'fsf', 'ave', 'vdy', '2025-02-13 16:51:44', '2025-02-13 16:51:44');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `data`
--
ALTER TABLE `data`
  ADD PRIMARY KEY (`ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `data`
--
ALTER TABLE `data`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
