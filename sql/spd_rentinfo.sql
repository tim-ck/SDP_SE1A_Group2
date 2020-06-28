CREATE DATABASE  IF NOT EXISTS `spd` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `spd`;
-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: spd
-- ------------------------------------------------------
-- Server version	5.7.21-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `rentinfo`
--

DROP TABLE IF EXISTS `rentinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rentinfo` (
  `rentID` varchar(15) NOT NULL,
  `tenantID` varchar(15) NOT NULL,
  `startDate` date NOT NULL,
  `duration` int(11) NOT NULL,
  `showcaseid` varchar(45) NOT NULL,
  PRIMARY KEY (`rentID`),
  KEY `reinfo_showcaseid_fk_idx` (`showcaseid`),
  KEY `rentinfo_tenantid_fk_idx` (`tenantID`),
  CONSTRAINT `rentinfo_showcaseid_fk` FOREIGN KEY (`showcaseid`) REFERENCES `showcase` (`showcaseid`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `rentinfo_tenantid_fk` FOREIGN KEY (`tenantID`) REFERENCES `tenant` (`tenantID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rentinfo`
--

LOCK TABLES `rentinfo` WRITE;
/*!40000 ALTER TABLE `rentinfo` DISABLE KEYS */;
INSERT INTO `rentinfo` VALUES ('1','1','2020-06-01',10,'sht001'),('2','2','2020-06-01',10,'cwb001'),('3','3','2020-06-01',10,'mka001'),('4','4','2020-06-01',10,'mkb001'),('5','5','2020-06-01',10,'kwf001'),('6','5','2020-06-02',10,'cwb002');
/*!40000 ALTER TABLE `rentinfo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-29  0:01:34
