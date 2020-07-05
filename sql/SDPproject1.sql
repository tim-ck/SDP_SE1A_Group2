CREATE DATABASE  IF NOT EXISTS `sdp` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `sdp`;
-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: sdp
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
-- Table structure for table `attendence`
--

DROP TABLE IF EXISTS `attendence`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `attendence` (
  `staffID` int(20) NOT NULL,
  `month` varchar(10) NOT NULL,
  `hour` int(3) NOT NULL,
  PRIMARY KEY (`staffID`,`month`),
  KEY `attendencestaffID` (`staffID`),
  CONSTRAINT `attendence_ibfk_2` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `attendence`
--

LOCK TABLES `attendence` WRITE;
/*!40000 ALTER TABLE `attendence` DISABLE KEYS */;
/*!40000 ALTER TABLE `attendence` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `customerID` varchar(20) NOT NULL,
  `customerpwd` varchar(20) NOT NULL,
  `customername` varchar(50) NOT NULL,
  `email` varchar(80) NOT NULL,
  `phone` varchar(50) NOT NULL,
  PRIMARY KEY (`customerID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES ('customer01','pass01','customer01','tim.ckchow@gmail.com','51776008'),('customer02','pass02','custoemer02','tim.ckchow@gmail.com','51776008');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `item`
--

DROP TABLE IF EXISTS `item`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item` (
  `itemID` varchar(15) NOT NULL,
  `tenantID` varchar(20) NOT NULL,
  `itemName` varchar(45) NOT NULL,
  `itemDesc` varchar(45) DEFAULT NULL,
  `unitPrice` float NOT NULL,
  PRIMARY KEY (`itemID`),
  KEY `item_tenantid_fk_idx` (`tenantID`),
  CONSTRAINT `item_tenantid_fk` FOREIGN KEY (`tenantID`) REFERENCES `tenant` (`tenantID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item`
--

LOCK TABLES `item` WRITE;
/*!40000 ALTER TABLE `item` DISABLE KEYS */;
INSERT INTO `item` VALUES ('100','tenant01','Apple','an aplle',10),('120','tenant01','coffe','Black coffe',20),('200','tenant02','hat','not green',151),('300','tenant01','air','light as air',40),('400','tenant02','banana','banana in a showcase',20),('500','tenant02','tea bag','Everone want tea bag',54);
/*!40000 ALTER TABLE `item` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itemimage`
--

DROP TABLE IF EXISTS `itemimage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `itemimage` (
  `itemImageID` varchar(15) NOT NULL,
  `filename` varchar(45) NOT NULL,
  `picture` blob NOT NULL,
  `itemID` varchar(15) NOT NULL,
  PRIMARY KEY (`itemImageID`),
  KEY `itemimage_itemid_fk_idx` (`itemID`),
  CONSTRAINT `itemimage_itemid_fk` FOREIGN KEY (`itemID`) REFERENCES `item` (`itemID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itemimage`
--

LOCK TABLES `itemimage` WRITE;
/*!40000 ALTER TABLE `itemimage` DISABLE KEYS */;
/*!40000 ALTER TABLE `itemimage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order` (
  `orderID` varchar(15) NOT NULL,
  `storeName` varchar(80) NOT NULL,
  `customerID` varchar(15) NOT NULL,
  `orderDate` date NOT NULL,
  `orderTotalPrice` float NOT NULL,
  PRIMARY KEY (`orderID`),
  KEY `order_customerid_fk_idx` (`customerID`),
  CONSTRAINT `order_customerID_fk` FOREIGN KEY (`customerID`) REFERENCES `customer` (`customerID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES ('001','MK','customer01','2020-06-01',30),('002','mk','customer02','2020-06-03',10);
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_detail`
--

DROP TABLE IF EXISTS `order_detail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_detail` (
  `orderID` varchar(15) NOT NULL,
  `itemID` varchar(15) NOT NULL,
  `unitPrice` float NOT NULL,
  `qty` int(11) NOT NULL,
  `totalPrice` float NOT NULL,
  PRIMARY KEY (`orderID`,`itemID`),
  KEY `order_detail_orderID` (`orderID`),
  KEY `order_detail_itemID` (`itemID`),
  CONSTRAINT `order_customerID_fk1` FOREIGN KEY (`orderID`) REFERENCES `order` (`orderID`),
  CONSTRAINT `order_customerID_fk2` FOREIGN KEY (`itemID`) REFERENCES `item` (`itemID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_detail`
--

LOCK TABLES `order_detail` WRITE;
/*!40000 ALTER TABLE `order_detail` DISABLE KEYS */;
INSERT INTO `order_detail` VALUES ('001','100',10,1,10),('001','120',20,1,20),('002','100',10,1,10);
/*!40000 ALTER TABLE `order_detail` ENABLE KEYS */;
UNLOCK TABLES;

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
  PRIMARY KEY (`preinputitemid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `preinputitem`
--

LOCK TABLES `preinputitem` WRITE;
/*!40000 ALTER TABLE `preinputitem` DISABLE KEYS */;
INSERT INTO `preinputitem` VALUES ('001','pre-input item 1',10,'pre-input item 1 descc',10,'tenant01'),('002','pre-input item 2',20,'pre-input item 2 desc',25,'tenant01'),('003','pre-input item 3',10,'pre-input item 3 descc',100,'tenant01'),('004','pre-input item 4',15,'pre-input item 4 descc',455,'tenant01'),('005','pre-input item 5',7,'pre-input item 5 descc',57,'tenant01'),('006','pre-input item 6',5,'pre-input item 6 descc',100,'tenant01'),('007','pre-input item 7',7,'pre-input item 7 descc',777.7,'tenant01'),('008','pre-input item 8',12,'pre-input item 8 descc',546,'tenant02'),('009','pre-input item 9',5,'pre-input item 9 descc',255,'tenant02'),('010','pre-input item 10',7,'pre-input item 10 dscsd',12,'tenant01');
/*!40000 ALTER TABLE `preinputitem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rentinfo`
--

DROP TABLE IF EXISTS `rentinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rentinfo` (
  `rentID` varchar(20) NOT NULL,
  `tenantID` varchar(20) NOT NULL,
  `startDate` date NOT NULL,
  `duration` int(11) NOT NULL,
  `showcaseid` varchar(6) NOT NULL,
  PRIMARY KEY (`rentID`),
  KEY `rentinfo_showcaseid` (`showcaseid`),
  KEY `rentinfo_tenantID` (`tenantID`),
  CONSTRAINT `rentinfo_showcaseid_fk` FOREIGN KEY (`showcaseid`) REFERENCES `showcase` (`showcaseid`),
  CONSTRAINT `rentinfo_tenantid_fk` FOREIGN KEY (`tenantID`) REFERENCES `tenant` (`tenantID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rentinfo`
--

LOCK TABLES `rentinfo` WRITE;
/*!40000 ALTER TABLE `rentinfo` DISABLE KEYS */;
INSERT INTO `rentinfo` VALUES ('1','tenant01','2020-06-01',10,'sht001'),('2','tenant01','2020-06-01',10,'cwb001'),('3','tenant01','2020-06-01',10,'mka001'),('4','tenant01','2020-06-01',10,'mkb001'),('5','tenant01','2020-06-01',10,'kwf001'),('6','tenant02','2020-06-02',10,'cwb002');
/*!40000 ALTER TABLE `rentinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservation` (
  `reservationid` varchar(15) NOT NULL,
  `showcaseid` varchar(15) NOT NULL,
  `tenantid` varchar(15) NOT NULL,
  PRIMARY KEY (`reservationid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservation`
--

LOCK TABLES `reservation` WRITE;
/*!40000 ALTER TABLE `reservation` DISABLE KEYS */;
/*!40000 ALTER TABLE `reservation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `showcase`
--

DROP TABLE IF EXISTS `showcase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `showcase` (
  `showcaseid` varchar(6) NOT NULL,
  `size` int(11) NOT NULL,
  `rental` float NOT NULL,
  `status` varchar(15) NOT NULL,
  `availability` tinyint(4) NOT NULL,
  PRIMARY KEY (`showcaseid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `showcase`
--

LOCK TABLES `showcase` WRITE;
/*!40000 ALTER TABLE `showcase` DISABLE KEYS */;
INSERT INTO `showcase` VALUES ('',0,0,'',0),('cwb001',50000,5,'a',0),('cwb002',30000,3,'o',0),('cwb003',40000,4,'a',0),('cwb004',30000,3,'a',0),('cwb005',30000,3,'a',0),('cwb006',30000,3,'a',0),('cwb007',40000,4,'a',0),('cwb008',50000,5,'a',0),('cwb009',30000,3,'a',0),('cwb010',30000,3,'a',0),('cwb011',30000,3,'a',0),('cwb012',30000,3,'a',0),('cwb013',40000,4,'a',0),('cwb014',40000,4,'a',0),('cwb015',40000,4,'a',0),('cwb016',40000,4,'a',0),('cwb017',50000,5,'a',0),('cwb018',30000,3,'a',0),('cwb019',40000,4,'a',0),('cwb020',30000,3,'a',0),('cwb021',50000,5,'a',0),('cwb022',40000,4,'a',0),('cwb023',40000,4,'a',0),('cwb024',50000,5,'a',0),('cwb025',50000,5,'a',0),('cwb026',30000,3,'a',0),('cwb027',30000,3,'a',0),('cwb028',40000,4,'a',0),('cwb029',30000,3,'a',0),('cwb030',50000,5,'a',0),('cwb031',30000,3,'a',0),('cwb032',40000,4,'a',0),('kwf001',30000,3,'r',0),('kwf002',40000,4,'r',0),('kwf003',40000,4,'r',0),('kwf004',30000,3,'a',0),('kwf005',40000,4,'a',0),('kwf006',50000,5,'a',0),('kwf007',50000,5,'a',0),('kwf008',50000,5,'a',0),('kwf009',30000,3,'a',0),('kwf010',40000,4,'a',0),('kwf011',30000,3,'a',0),('kwf012',30000,3,'a',0),('kwf013',50000,5,'a',0),('kwf014',50000,5,'a',0),('kwf015',40000,4,'a',0),('kwf016',50000,5,'a',0),('kwf017',30000,3,'a',0),('kwf018',50000,5,'a',0),('kwf019',30000,3,'a',0),('kwf020',40000,4,'a',0),('kwf021',40000,4,'a',0),('kwf022',50000,5,'a',0),('kwf023',40000,4,'a',0),('kwf024',50000,5,'a',0),('kwf025',30000,3,'a',0),('kwf026',30000,3,'a',0),('kwf027',30000,3,'a',0),('kwf028',50000,5,'a',0),('kwf029',40000,4,'a',0),('kwf030',40000,4,'a',0),('kwf031',40000,4,'a',0),('kwf032',50000,5,'a',0),('mka001',30000,3,'o',0),('mka002',30000,3,'a',0),('mka003',40000,4,'o',0),('mka004',30000,3,'a',0),('mka005',30000,3,'a',0),('mka006',30000,3,'a',0),('mka007',40000,4,'a',0),('mka008',40000,4,'a',0),('mka009',30000,3,'a',0),('mka010',40000,4,'a',0),('mka011',50000,5,'a',0),('mka012',50000,5,'a',0),('mka013',30000,3,'a',0),('mka014',50000,5,'a',0),('mka015',50000,5,'a',0),('mka016',30000,3,'a',0),('mka017',40000,4,'a',0),('mka018',30000,3,'a',0),('mka019',30000,3,'a',0),('mka020',50000,5,'a',0),('mka021',30000,3,'a',0),('mka022',30000,3,'a',0),('mka023',40000,4,'a',0),('mka024',40000,4,'a',0),('mka025',50000,5,'a',0),('mka026',40000,4,'a',0),('mka027',40000,4,'a',0),('mka028',40000,4,'a',0),('mka029',40000,4,'a',0),('mka030',30000,3,'a',0),('mka031',30000,3,'a',0),('mka032',30000,3,'a',0),('mkb001',50000,5,'a',0),('mkb002',50000,5,'r',0),('mkb003',40000,4,'a',0),('mkb004',40000,4,'a',0),('mkb005',40000,4,'a',0),('mkb006',40000,4,'a',0),('mkb007',40000,4,'a',0),('mkb008',30000,3,'a',0),('mkb009',50000,5,'a',0),('mkb010',50000,5,'a',0),('mkb011',50000,5,'a',0),('mkb012',50000,5,'a',0),('mkb013',30000,3,'a',0),('mkb014',30000,3,'a',0),('mkb015',50000,5,'a',0),('mkb016',40000,4,'a',0),('mkb017',30000,3,'a',0),('mkb018',50000,5,'a',0),('mkb019',40000,4,'a',0),('mkb020',30000,3,'a',0),('mkb021',40000,4,'a',0),('mkb022',40000,4,'a',0),('mkb023',40000,4,'a',0),('mkb024',50000,5,'a',0),('mkb025',50000,5,'a',0),('mkb026',50000,5,'a',0),('mkb027',50000,5,'a',0),('mkb028',50000,5,'a',0),('mkb029',40000,4,'a',0),('mkb030',40000,4,'a',0),('mkb031',50000,5,'a',0),('mkb032',50000,5,'a',0),('sht001',30000,3,'o',0),('sht002',40000,4,'r',0),('sht003',50000,5,'a',0),('sht004',50000,5,'a',0),('sht005',50000,5,'a',0),('sht006',50000,5,'a',0),('sht007',50000,5,'a',0),('sht008',50000,5,'a',0),('sht009',40000,4,'a',0),('sht010',50000,5,'a',0),('sht011',30000,3,'a',0),('sht012',40000,4,'a',0),('sht013',50000,5,'a',0),('sht014',30000,3,'a',0),('sht015',50000,5,'a',0),('sht016',30000,3,'a',0),('sht017',30000,3,'a',0),('sht018',40000,4,'a',0),('sht019',40000,4,'a',0),('sht020',40000,4,'a',0),('sht021',50000,5,'a',0),('sht022',40000,4,'a',0),('sht023',50000,5,'a',0),('sht024',40000,4,'a',0),('sht025',50000,5,'a',0),('sht026',50000,5,'a',0),('sht027',40000,4,'a',0),('sht028',30000,3,'a',0),('sht029',30000,3,'a',0),('sht030',30000,3,'a',0),('sht031',30000,3,'a',0),('sht032',50000,5,'a',0);
/*!40000 ALTER TABLE `showcase` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `showcaseitem`
--

DROP TABLE IF EXISTS `showcaseitem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `showcaseitem` (
  `showcaseid` varchar(6) NOT NULL,
  `itemid` varchar(15) NOT NULL,
  `avalibleQty` int(11) NOT NULL,
  `soldQty` int(11) NOT NULL,
  `TotalQty` int(11) NOT NULL,
  PRIMARY KEY (`showcaseid`,`itemid`),
  KEY `showcaseitemitemid` (`itemid`),
  KEY `showcaseitem_showcaseId` (`showcaseid`),
  CONSTRAINT `showcaseitem_itemid_fk` FOREIGN KEY (`itemid`) REFERENCES `item` (`itemID`),
  CONSTRAINT `showcaseitem_showcaseId_fk` FOREIGN KEY (`showcaseid`) REFERENCES `showcase` (`showcaseid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `showcaseitem`
--

LOCK TABLES `showcaseitem` WRITE;
/*!40000 ALTER TABLE `showcaseitem` DISABLE KEYS */;
INSERT INTO `showcaseitem` VALUES ('cwb001','100',50,5,55),('cwb001','120',5,5,5),('cwb002','200',3,2,5),('kwf001','200',3,2,5),('mka001','300',1,4,5),('mkb001','400',7,2,9),('sht001','500',10,0,10);
/*!40000 ALTER TABLE `showcaseitem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff` (
  `staffID` int(20) NOT NULL,
  `tenantpwd` varchar(20) NOT NULL,
  `email` varchar(100) NOT NULL,
  `name` varchar(50) NOT NULL,
  `staffType` char(2) NOT NULL,
  `reportsTo` int(11) DEFAULT NULL,
  `salary` float NOT NULL,
  PRIMARY KEY (`staffID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tenant`
--

DROP TABLE IF EXISTS `tenant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tenant` (
  `tenantID` varchar(20) NOT NULL,
  `tenantpwd` varchar(20) NOT NULL,
  `tenantName` varchar(50) NOT NULL,
  `email` varchar(80) NOT NULL,
  `phone` varchar(50) NOT NULL,
  PRIMARY KEY (`tenantID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tenant`
--

LOCK TABLES `tenant` WRITE;
/*!40000 ALTER TABLE `tenant` DISABLE KEYS */;
INSERT INTO `tenant` VALUES ('tenant01','pass01','tenant01','tim.ckchow@gmail.com','51776008'),('tenant02','pass02','tenant02','tim.ckchow@gmail.com','51776008');
/*!40000 ALTER TABLE `tenant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'sdp'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-05 16:22:11
