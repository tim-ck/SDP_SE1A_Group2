/*
*********************************************************************
http://www.mysqltutorial.org
*********************************************************************
Name: MySQL Sample Database SDP
Link: http://www.mysqltutorial.org/mysql-sample-database.aspx
Version 3.0
+ changed DATETIME to DATE for some colunmns
Version 2.0
+ changed table type to InnoDB
+ added foreign keys for all tables 
*********************************************************************
*/


/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`SDP` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `SDP`;
set global optimizer_switch='derived_merge=off';
set optimizer_switch='derived_merge=off';
/*Table structure for table `customer` */

DROP TABLE IF EXISTS `customer`;

CREATE TABLE `customer` (
  `customerID` varchar(20) NOT NULL,
  `customerpwd`varchar(20) NOT NULL,
  `customername` varchar(50) NOT NULL,
  `email` varchar(80) NOT NULL,
  `phone` varchar(50) NOT NULL,
  PRIMARY KEY (`customerID`)
)ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `customer` */

LOCK TABLES `customer` WRITE;

insert  into `customer`(`customerID`,`customerpwd`,`customername`,`email`,`phone`) values ('customer01','pass01','customer01','tim.ckchow@gmail.com','51776008'),('customer02','pass02','custoemer02','tim.ckchow@gmail.com','51776008');

UNLOCK TABLES;

/*Table structure for table `tenant` */

DROP TABLE IF EXISTS `tenant`;

CREATE TABLE `tenant` (
  `tenantID` varchar(20) NOT NULL,
  `tenantpwd`varchar(20) NOT NULL,
  `tenantName` varchar(50) NOT NULL,
  `email` varchar(80) NOT NULL,
  `phone` varchar(50) NOT NULL,
  PRIMARY KEY (`tenantID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tenant` */

LOCK TABLES `tenant` WRITE;
INSERT INTO `tenant`(`tenantID`,`tenantpwd`,`tenantName`,`email`,`phone`) values('tenant01','pass01','tenant01','tim.ckchow@gmail.com','51776008'),('tenant02','pass02','tenant02','tim.ckchow@gmail.com','51776008');

UNLOCK TABLES;


/*Table structure for table `rentinfo` */

DROP TABLE IF EXISTS `rentinfo`;

CREATE TABLE `rentinfo` (
  `rentID` varchar(20) NOT NULL,
  `tenantID` varchar(20) NOT NULL,
  `startDate` date NOT NULL,
  `duration` int(11) NOT NULL,
  `showcaseid` varchar(6) NOT NULL,
  `storeID` varchar(15) NOT NULL,

  PRIMARY KEY (`rentID`),
  KEY `rentinfo_showcaseid` (`showcaseid`),
  KEY `rentinfo_tenantID` (`tenantID`),
   KEY `_storeID_fk`(`storeID`),
  CONSTRAINT `_storeID_fk` FOREIGN KEY (`storeID`) REFERENCES `store`(`storeID`),

  CONSTRAINT `rentinfo_showcaseid_fk` FOREIGN KEY (`showcaseid`) REFERENCES `showcase` (`showcaseid`) ,
  CONSTRAINT `rentinfo_tenantid_fk` FOREIGN KEY (`tenantID`) REFERENCES `tenant` (`tenantID`) 
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `rentinfo` */
LOCK TABLES `rentinfo` WRITE;
INSERT INTO `rentinfo` (`rentID`,`tenantID`,`startDate`,`duration`,`showcaseid`) VALUES ('1','tenant01','2020-06-01',10,'sht001'),('2','tenant01','2020-06-01',10,'cwb001'),('3','tenant01','2020-06-01',10,'mka001'),('4','tenant01','2020-06-01',10,'mkb001'),('5','tenant01','2020-06-01',10,'kwf001'),('6','tenant02','2020-06-02',10,'cwb002');
UNLOCK TABLES;







/*Table structure for table `showcaseitem` */
DROP TABLE IF EXISTS `showcaseitem`;

CREATE TABLE `showcaseitem` (
  `showcaseid` varchar(6) NOT NULL,
  `storeID` varchar(15) NOT NULL,

  `itemid` varchar(15) NOT NULL,
  `avalibleQty` int(11) NOT NULL,
  `soldQty`int(11) NOT NULL,
  `TotalQty` int(11) NOT NULL,
  CONSTRAINT `showcaseitem_pk` PRIMARY KEY(`showcaseId`,`itemid`),
  KEY `showcaseitemitemid` (`itemid`),
  KEY `showcaseitem_showcaseId` (`showcaseId`),
  KEY `showcaseitem_storeID_fk`(`storeID`),
  CONSTRAINT `showcaseitem_storeID_fk` FOREIGN KEY (`storeID`) REFERENCES `store`(`storeID`),

  CONSTRAINT `showcaseitem_showcaseId_fk` FOREIGN KEY (`showcaseId`) REFERENCES `showcase` (`showcaseid`), 
  CONSTRAINT `showcaseitem_itemid_fk` FOREIGN KEY (`itemid`) REFERENCES `item` (`itemID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `showcaseitem` */
LOCK TABLES `showcaseitem` WRITE;
INSERT INTO `showcaseitem` VALUES ('cwb001',100,50,5,55),('cwb001',120,5,5,5),('cwb002',200,3,2,5),('kwf001',200,3,2,5),('mka001',300,1,4,5),('mkb001',400,7,2,9),('sht001',500,10,0,10);
UNLOCK TABLES;

/*Table structure for table `item` */
DROP TABLE IF EXISTS `item`;

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

/*Data for the table `item` */
LOCK TABLES `item` WRITE;
INSERT INTO `item` VALUES ('100','tenant01','Apple','an aplle',10),('120','tenant01','coffe','Black coffe',20),('300','tenant01','air','light as air',40),('400','tenant02','banana','banana in a showcase',20),('500','tenant02','tea bag','Everone want tea bag',54),('200','tenant02','hat','not green',151);
UNLOCK TABLES;







/*Table structure for table `itemimage` */

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





/*Table structure for table `order_detail` */

DROP TABLE IF EXISTS `order_detail`;

CREATE TABLE `order_detail` (
  `orderID` varchar(15) NOT NULL,
  `itemID` varchar(15) NOT NULL,
  `unitPrice` float NOT NULL,
  `qty` int(11) NOT NULL,
  `totalPrice` float NOT NULL,

  PRIMARY KEY (`orderID`,`itemID`),
  KEY `order_detail_orderID` (`orderID`),
  KEY `order_detail_itemID` (`itemID`),
  CONSTRAINT `order_customerID_fk1` FOREIGN KEY (`orderID`) REFERENCES `order`(`orderID`),
  CONSTRAINT `order_customerID_fk2` FOREIGN KEY (`itemID`) REFERENCES `item`(`itemID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `order_detail` */
LOCK TABLES `order_detail` WRITE;
INSERT INTO `order_detail` VALUES ('001','100',10,1,10) ,('001','120',20,1,20) , ('002','100',10,1,10);
UNLOCK TABLES;

/*Table structure for table `staff` */

DROP TABLE IF EXISTS `staff`;

CREATE TABLE `staff` (
  `staffID` int(20) NOT NULL,
  `tenantpwd`varchar(20) NOT NULL,
  `email` varchar(100) NOT NULL,
  `name` varchar(50) NOT NULL,
  `staffType` char(2) NOT NULL,
  `reportsTo` int(11) DEFAULT NULL,
  `salary` float NOT NULL,
  PRIMARY KEY (`staffID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `employees` */

LOCK TABLES `staff` WRITE;
UNLOCK TABLES;
/*Table structure for table `attendence` */

DROP TABLE IF EXISTS `attendence`;

CREATE TABLE `attendence` (
  `staffID` int(20) NOT NULL,
  `month` varchar(10) NOT NULL,
  `hour` int(3) NOT NULL,
  PRIMARY KEY (`staffID`,`month`),
  KEY `attendencestaffID` (`staffID`),
  CONSTRAINT `attendence_ibfk_2` FOREIGN KEY (`staffID`) REFERENCES `staff` (`staffID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `employees` */

LOCK TABLES `staff` WRITE;
UNLOCK TABLES;



/*need to change !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/




DROP TABLE IF EXISTS `reservation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservation` (
  `reservationid` varchar(15) NOT NULL,
  `showcaseid` varchar(15) NOT NULL,
  `rentid` varchar(15) NOT NULL,
  PRIMARY KEY (`reservationid`),
  KEY `reservation_showcaseid_fk_idx` (`showcaseid`),
  KEY `reservation_rentid_fk_idx` (`rentid`),
  CONSTRAINT `reservation_rentid_fk` FOREIGN KEY (`rentid`) REFERENCES `rentinfo` (`rentID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `reservation_showcaseid_fk` FOREIGN KEY (`showcaseid`) REFERENCES `showcase` (`showcaseid`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservation`
--

LOCK TABLES `reservation` WRITE;
/*!40000 ALTER TABLE `reservation` DISABLE KEYS */;
/*!40000 ALTER TABLE `reservation` ENABLE KEYS */;
UNLOCK TABLES;



/*Table structure for table `showcase` */
DROP TABLE IF EXISTS `showcase`;

CREATE TABLE `showcase` (
  `showcaseid` varchar(6) NOT NULL,
  `storeID` varchar(15) NOT NULL,
  `size` int(11) NOT NULL,
  `rental` float NOT NULL,
  `status` varchar(15) NOT NULL,
  PRIMARY KEY (`showcaseid`)
  KEY `showcase_storeID_fk`(`storeID`),
  CONSTRAINT `showcase_storeID_fk` FOREIGN KEY (`storeID`) REFERENCES `store`(`storeID`)

) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*Data for the table `showcase` */
LOCK TABLES `showcase` WRITE;
INSERT INTO `showcase` VALUES ('cwb001',50000,5,'a'),('cwb002',30000,3,'o'),('cwb003',40000,4,'a'),('kwf001',30000,3,'r'),('kwf002',40000,4,'r'),('kwf003',40000,4,'r'),('mka001',30000,3,'o'),('mka002',30000,3,'a'),('mka003',40000,4,'o'),('mkb001',50000,5,'a'),('mkb002',50000,5,'r'),('mkb003',40000,4,'a'),('sht001',30000,3,'o'),('sht002',40000,4,'r'),('sht003',50000,5,'a');
UNLOCK TABLES;


/*Table structure for table `order` */
DROP TABLE IF EXISTS `order`;

CREATE TABLE `order` (
  `orderID` varchar(15) NOT NULL,
  `storeID` varchar(15) NOT NULL,
  `customerID` varchar(15) NOT NULL,
  `orderDate` date NOT NULL,
  `orderTotalPrice` float NOT NULL,
  PRIMARY KEY (`orderID`),
  KEY `order_customerid_fk_idx` (`customerID`),
  KEY `order_storeID_fk`(`storeID`),
  CONSTRAINT `order_customerID_fk` FOREIGN KEY (`customerID`) REFERENCES `customer`(`customerID`),
  CONSTRAINT `order_storeID_fk` FOREIGN KEY (`storeID`) REFERENCES `store`(`storeID`)

) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `order` */

LOCK TABLES `order` WRITE;
INSERT INTO `order` VALUES ('001','mka','customer01','2020-06-01',30),('002','mka','customer02','2020-06-03',10);
UNLOCK TABLES;



/*Table structure for table `store` */
DROP TABLE IF EXISTS `store`;

CREATE TABLE `store` (
  `storeID` varchar(15) NOT NULL,
  `storeAddress` varchar(255) NOT NULL,
  
  PRIMARY KEY (`storeID`),
 ) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `order` */

LOCK TABLES `order` WRITE;
INSERT INTO `order` VALUES ('cwb'  ,'UG03, ABC Mall'),('kwf'  ,'LG22, DEF Commercial Centre'),('mka'  ,'203, G.H.I Mall'),('mkb'  ,'LG123, Kwai Fong Plaza'),('sht'  ,'888, New ST Plaza');
UNLOCK TABLES;







/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
 