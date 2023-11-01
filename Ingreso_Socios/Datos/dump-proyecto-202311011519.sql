-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: proyecto
-- ------------------------------------------------------
-- Server version	8.0.34

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `actividad`
--

DROP TABLE IF EXISTS `actividad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `actividad` (
  `idActividad` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `costo` float NOT NULL,
  PRIMARY KEY (`idActividad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `actividad`
--

LOCK TABLES `actividad` WRITE;
/*!40000 ALTER TABLE `actividad` DISABLE KEYS */;
/*!40000 ALTER TABLE `actividad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `actividadnosocio`
--

DROP TABLE IF EXISTS `actividadnosocio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `actividadnosocio` (
  `idActividad` int NOT NULL,
  `idNoSocio` int NOT NULL,
  `idActividadNoSocio` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`idActividadNoSocio`),
  KEY `actividadNoSocio_FK` (`idNoSocio`),
  KEY `actividadNoSocio_FK_1` (`idActividad`),
  CONSTRAINT `actividadNoSocio_FK` FOREIGN KEY (`idNoSocio`) REFERENCES `nosocio` (`idNoSocio`),
  CONSTRAINT `actividadNoSocio_FK_1` FOREIGN KEY (`idActividad`) REFERENCES `actividad` (`idActividad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `actividadnosocio`
--

LOCK TABLES `actividadnosocio` WRITE;
/*!40000 ALTER TABLE `actividadnosocio` DISABLE KEYS */;
/*!40000 ALTER TABLE `actividadnosocio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuota`
--

DROP TABLE IF EXISTS `cuota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuota` (
  `idCuota` int NOT NULL AUTO_INCREMENT,
  `idSocio` int NOT NULL,
  `monto` float NOT NULL,
  `fechaVencimiento` date NOT NULL,
  `periodio` varchar(100) NOT NULL,
  `medioPago` varchar(100) NOT NULL,
  `fechaEmision` date NOT NULL,
  PRIMARY KEY (`idCuota`),
  KEY `cuota_FK` (`idSocio`),
  CONSTRAINT `cuota_FK` FOREIGN KEY (`idSocio`) REFERENCES `socio` (`idSocio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuota`
--

LOCK TABLES `cuota` WRITE;
/*!40000 ALTER TABLE `cuota` DISABLE KEYS */;
/*!40000 ALTER TABLE `cuota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nosocio`
--

DROP TABLE IF EXISTS `nosocio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nosocio` (
  `idNoSocio` int NOT NULL AUTO_INCREMENT,
  `idPersona` int NOT NULL,
  PRIMARY KEY (`idNoSocio`),
  KEY `noSocio_FK` (`idPersona`),
  CONSTRAINT `noSocio_FK` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nosocio`
--

LOCK TABLES `nosocio` WRITE;
/*!40000 ALTER TABLE `nosocio` DISABLE KEYS */;
/*!40000 ALTER TABLE `nosocio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `persona` (
  `idPersona` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `apellido` varchar(100) NOT NULL,
  `fechaNac` date NOT NULL,
  `dni` bigint NOT NULL,
  `aptoFisico` tinyint(1) NOT NULL,
  PRIMARY KEY (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (1,'sergio','acosta','1984-10-27',31309515,1),(2,'juan','Perez','2023-12-01',25,1),(3,'diego','Perez','2023-12-01',85,1),(4,'diego','Perez','2023-12-01',85,1),(5,'diego','Perez','2023-12-01',85,1),(6,'diego','Perez','2023-12-01',2325,1),(7,'diego','Perez','2023-12-01',2325,1),(8,'diego','Perez','2023-12-01',2325,1),(9,'jose','rodriguez','2023-12-01',30,1),(10,'jose','rodriguez','2023-12-01',30,1),(11,'jose','rodriguez','2023-12-01',30,1),(12,'jose','rodriguez','2023-12-01',30,1),(13,'jose','rodriguez','2023-12-01',29,1),(14,'jose','rodriguez','2023-12-01',29,1),(15,'jose','rodriguez','2023-12-01',29,1),(16,'jose','rodriguez','2023-12-01',29,1),(17,'jose','rodriguez','2023-12-01',29,1),(18,'jose','rodriguez','2023-12-01',29,1),(19,'jose','rodriguez','2023-12-01',78,1),(20,'jose','rodriguez','2023-12-01',8,1),(21,'tom','jerry','2023-10-30',4998,1),(22,'martin','diaz','2023-10-30',764982,0),(23,'jose','rodriguez','2023-12-01',1984,1),(24,'ian','toloza','1993-10-26',1567,1),(25,'jon','rod','2023-12-01',145,1),(26,'loss','coll','1899-10-25',24269,1),(27,'andres ','baez','1996-02-14',40296488,1),(28,'orlando','gimenez','2023-10-31',164978,0),(29,'alberto','fernandez','2023-10-31',123456,1),(30,'ricardo','caruzo','1989-05-07',234689,1);
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `Rol` int NOT NULL,
  `NomRol` varchar(30) COLLATE latin1_bin DEFAULT NULL,
  PRIMARY KEY (`Rol`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_bin;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrador'),(2,'Empleado');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `socio`
--

DROP TABLE IF EXISTS `socio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `socio` (
  `idSocio` int NOT NULL AUTO_INCREMENT,
  `idPersona` int NOT NULL,
  PRIMARY KEY (`idSocio`),
  KEY `socio_FK` (`idPersona`),
  CONSTRAINT `socio_FK` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `socio`
--

LOCK TABLES `socio` WRITE;
/*!40000 ALTER TABLE `socio` DISABLE KEYS */;
INSERT INTO `socio` VALUES (3,20),(4,25),(5,26),(6,27),(7,28),(8,29),(9,30);
/*!40000 ALTER TABLE `socio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `IdUsuario` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `contrasena` varchar(100) NOT NULL,
  `Rol` int DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`IdUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'juan','perez',1,1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'proyecto'
--
/*!50003 DROP PROCEDURE IF EXISTS `IngresoLogin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin`(in Usu varchar(20),in Pass varchar(15))
begin
  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  select NomRol
	from usuario u inner join roles r on u.Rol = r.Rol
		where nombre = Usu and contrasena = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */


end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `NuevoSocio` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `NuevoSocio`( in idP int, in Nom varchar(30),in Ape varchar(40),in Dni int, in Fnac Date, in Afis Bit,out rta int)
BEGIN
     declare existeP int default 0;
	 declare existeS int default 0;
	 declare idS int default 0;
    
     set existeP = (select count(*) from persona as p where p.dni= Dni);
     if existeP = 0  then
     	insert into persona values(idP,Nom,Ape,Fnac,Dni,Afis);
     end if;
	 set existeS = (select count(*) from persona as p join socio as s on p.idPersona = s.idPersona where p.dni=Dni);
     set rta  = existeS;
	 if existeS = 0 then
		set idP = (select idPersona from persona as p where p.dni=Dni);
		insert into socio values(ids,idP);
		set rta  = (select idSocio from socio as s where s.idPersona=idP);
	   else
		 set rta = 0;
      end if;		 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-01 15:19:03
