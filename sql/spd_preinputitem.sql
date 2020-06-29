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
-- Table structure for table `preinputitem`
--

DROP TABLE IF EXISTS `preinputitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `preinputitem` (
  `preinputitemid` varchar(15) NOT NULL,
  `itemname` varchar(45) NOT NULL,
  `itemqty` int(11) NOT NULL,
  `itemdesc` varchar(45) DEFAULT NULL,
  `itemunitprice` float NOT NULL,
  `tenantid` varchar(15) NOT NULL,
  PRIMARY KEY (`preinputitemid`),
  KEY `preinputitem_tenantid_fk_idx` (`tenantid`),
  CONSTRAINT `preinputitem_tenantid_fk` FOREIGN KEY (`tenantid`) REFERENCES `tenant` (`tenantID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `preinputitem`
--

LOCK TABLES `preinputitem` WRITE;
/*!40000 ALTER TABLE `preinputitem` DISABLE KEYS */;
INSERT INTO `preinputitem` VALUES ('1','pre-input item 1',10,'pre-input item 1 descc',10,'1'),('10','pre-input item 10',7,'pre-input item 10 dscsd',12,'5'),('2','pre-input item 2',20,'pre-input item 2 desc',25,'1'),('3','pre-input item 3',10,'pre-input item 3 descc',100,'2'),('4','pre-input item 4',15,'pre-input item 4 descc',455,'2'),('5','pre-input item 5',7,'pre-input item 5 descc',57,'3'),('6','pre-input item 6',5,'pre-input item 6 descc',100,'3'),('7','pre-input item 7',4,'pre-input item 7 descc',122,'4'),('8','pre-input item 8',12,'pre-input item 8 descc',546,'4'),('9','pre-input item 9',5,'pre-input item 9 descc',255,'5');
/*!40000 ALTER TABLE `preinputitem` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-06-29  9:42:19
