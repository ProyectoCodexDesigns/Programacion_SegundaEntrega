-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-08-2023 a las 02:03:35
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `proyectosisvianza`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `acompaña`
--

CREATE TABLE `acompaña` (
  `POSTRE` int(11) NOT NULL,
  `VIANDA` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asigna`
--

CREATE TABLE `asigna` (
  `RUTA` int(11) NOT NULL,
  `VEHICULO` int(11) DEFAULT NULL,
  `FECHA_ASIGNACION` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `caja`
--

CREATE TABLE `caja` (
  `ID_CAJA` int(11) NOT NULL,
  `FECHA_CREACION` date DEFAULT NULL,
  `DURACION` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `circula`
--

CREATE TABLE `circula` (
  `ESTADO` int(11) NOT NULL,
  `MENU` int(11) DEFAULT NULL,
  `FECHA_HORAINICIO` date DEFAULT NULL,
  `FECHA_HORAFIN` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `CI` int(11) NOT NULL,
  `NOMBRE` varchar(100) NOT NULL,
  `TELEFONO` varchar(20) NOT NULL,
  `DIRECCION` varchar(200) NOT NULL,
  `MAIL` varchar(100) NOT NULL,
  `ALERGIAS` varchar(200) NOT NULL,
  `TIPO` varchar(20) NOT NULL,
  `ESTADO` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`CI`, `NOMBRE`, `TELEFONO`, `DIRECCION`, `MAIL`, `ALERGIAS`, `TIPO`, `ESTADO`) VALUES
(11111111, 'asdasdasd', '1', 'a', 'a@a.a', 'a', 'Individual', 1),
(12345676, 'Esteban', '32222222', 'a', 'pepe@a.c', 'a', 'Individual', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compone`
--

CREATE TABLE `compone` (
  `MENU` int(11) NOT NULL,
  `VIANDA` int(11) DEFAULT NULL,
  `CANTIDAD_VIANDAS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contiene`
--

CREATE TABLE `contiene` (
  `PUNTO_ENTREGA` int(11) NOT NULL,
  `RUTA` int(11) DEFAULT NULL,
  `ORDEN_VISITA` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

CREATE TABLE `departamento` (
  `ID_DEPARTAMENTO` int(11) NOT NULL,
  `ZONA` varchar(50) DEFAULT NULL,
  `NOMBRE` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `efectua`
--

CREATE TABLE `efectua` (
  `SUCURSAL` int(11) NOT NULL,
  `PRODUCCION` int(11) DEFAULT NULL,
  `FECHA` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empaca`
--

CREATE TABLE `empaca` (
  `CAJA` int(11) NOT NULL,
  `MENU` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `entrega`
--

CREATE TABLE `entrega` (
  `VEHICULO` int(11) NOT NULL,
  `CLIENTE` int(11) DEFAULT NULL,
  `BOLETA` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `esta`
--

CREATE TABLE `esta` (
  `DEPARTAMENTO` int(11) NOT NULL,
  `PUNTO_ENTREGA` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estado`
--

CREATE TABLE `estado` (
  `ID_ESTADO` int(11) NOT NULL,
  `NOMBRE` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `estado`
--

INSERT INTO `estado` (`ID_ESTADO`, `NOMBRE`) VALUES
(1, 'En Stock'),
(2, 'En Produccion'),
(3, 'Solicitado'),
(4, 'Envasado'),
(5, 'Entregado'),
(6, 'Devuelto');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `genera`
--

CREATE TABLE `genera` (
  `PRODUCTO` int(11) NOT NULL,
  `PRODUCCION` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `incluye`
--

CREATE TABLE `incluye` (
  `PEDIDO` int(11) NOT NULL,
  `CAJA` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `menu`
--

CREATE TABLE `menu` (
  `ID_MENU` int(11) NOT NULL,
  `NOMBRE` varchar(50) DEFAULT NULL,
  `TIPO` varchar(50) DEFAULT NULL,
  `STOCK` int(11) DEFAULT NULL,
  `STOCK_MINIMO` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `menu`
--

INSERT INTO `menu` (`ID_MENU`, `NOMBRE`, `TIPO`, `STOCK`, `STOCK_MINIMO`) VALUES
(12, 'orgsa', 'VEGETARIANO', 100, 10),
(13, 'asdaw', 'CARNIVORO', 80, 15);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido`
--

CREATE TABLE `pedido` (
  `ID_PEDIDO` int(11) NOT NULL,
  `CANTIDAD_MENUS` int(11) NOT NULL,
  `DESCRIPCION` varchar(255) DEFAULT NULL,
  `FECHA_ENTREGA` date NOT NULL,
  `FECHA_CREACION` timestamp NOT NULL DEFAULT current_timestamp(),
  `CI_CLIENTE` int(11) NOT NULL,
  `ESTADO` int(11) NOT NULL,
  `TIPO_MENU` int(11) NOT NULL,
  `CANTIDAD_VIANDAS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `pedido`
--

INSERT INTO `pedido` (`ID_PEDIDO`, `CANTIDAD_MENUS`, `DESCRIPCION`, `FECHA_ENTREGA`, `FECHA_CREACION`, `CI_CLIENTE`, `ESTADO`, `TIPO_MENU`, `CANTIDAD_VIANDAS`) VALUES
(7, 12, 'a', '2001-01-01', '2023-08-20 19:28:26', 11111111, 2, 0, 0),
(11, 12, 'aaaa', '2011-11-11', '2023-08-23 15:53:05', 11111111, 1, 12, 123);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pertenece`
--

CREATE TABLE `pertenece` (
  `SUCURSAL` int(11) NOT NULL,
  `VEHICULO` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `postre`
--

CREATE TABLE `postre` (
  `ID_POSTRE` int(11) NOT NULL,
  `NOMBRE` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `produccion`
--

CREATE TABLE `produccion` (
  `ID_PRODUCCION` int(11) NOT NULL,
  `FECHA_PRODUCCION` date DEFAULT NULL,
  `CANTIDAD` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `punto_entrega`
--

CREATE TABLE `punto_entrega` (
  `ID_PUNTOENTREGA` int(11) NOT NULL,
  `LATITUD` decimal(10,8) DEFAULT NULL,
  `LONGITUD` decimal(11,8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `realiza`
--

CREATE TABLE `realiza` (
  `CLIENTE` int(11) NOT NULL,
  `PEDIDO` int(11) DEFAULT NULL,
  `FECHA_REALIZACION` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reside`
--

CREATE TABLE `reside` (
  `DEPARTAMENTO` int(11) NOT NULL,
  `SUCURSAL` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ruta`
--

CREATE TABLE `ruta` (
  `ID_RUTA` int(11) NOT NULL,
  `HORA_INICIO` time DEFAULT NULL,
  `HORA_FIN` time DEFAULT NULL,
  `TIEMPO_TOTAL` time DEFAULT NULL,
  `DISTANCIA_TOTAL` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `solicita`
--

CREATE TABLE `solicita` (
  `CLIENTE` int(11) NOT NULL,
  `MENU` int(11) DEFAULT NULL,
  `FECHA` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sucursal`
--

CREATE TABLE `sucursal` (
  `ID_SUCURSAL` int(11) NOT NULL,
  `TELEFONO` int(11) DEFAULT NULL,
  `NOMBRE` varchar(100) DEFAULT NULL,
  `DESCRIPCION` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `transita`
--

CREATE TABLE `transita` (
  `ESTADO` int(11) NOT NULL,
  `PEDIDO` int(11) DEFAULT NULL,
  `FECHA_HORAINICIO` date DEFAULT NULL,
  `FECHA_HORAFIN` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `transporta`
--

CREATE TABLE `transporta` (
  `PEDIDO` int(11) NOT NULL,
  `VEHICULO` int(11) NOT NULL,
  `ORDEN_ENTREGA` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `CI` int(8) NOT NULL,
  `CONTRASEÑA` varchar(50) DEFAULT NULL,
  `ROL` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`CI`, `CONTRASEÑA`, `ROL`) VALUES
(11111111, 'aaa', 'Administrador'),
(12345678, 'aaa', 'Informático'),
(22222222, 'aaa', 'Encargado De Transporte'),
(33333333, 'aaa', 'Atención Al Público'),
(55555555, 'aaa', 'Atención Al Público');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vehiculo`
--

CREATE TABLE `vehiculo` (
  `ID_VEHICULO` int(11) NOT NULL,
  `CAPACIDAD_CARGA` decimal(10,2) DEFAULT NULL,
  `TIPO` varchar(50) DEFAULT NULL,
  `DISPONIBILIDAD` tinyint(1) DEFAULT NULL,
  `CANTIDAD_PEDIDOS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vianda`
--

CREATE TABLE `vianda` (
  `ID_VIANDA` int(11) NOT NULL,
  `NOMBRE` varchar(50) DEFAULT NULL,
  `FECHA_CADUCIDAD` date DEFAULT NULL,
  `TIEMPO` varchar(50) DEFAULT NULL,
  `POSTRE` tinyint(1) DEFAULT NULL,
  `TIPO_MENU` varchar(30) DEFAULT NULL,
  `DESCRIPCION` text DEFAULT NULL,
  `ESTADO` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vive`
--

CREATE TABLE `vive` (
  `DEPARTAMENTO` int(11) NOT NULL,
  `CLIENTE` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `acompaña`
--
ALTER TABLE `acompaña`
  ADD PRIMARY KEY (`POSTRE`),
  ADD KEY `VIANDA` (`VIANDA`);

--
-- Indices de la tabla `asigna`
--
ALTER TABLE `asigna`
  ADD PRIMARY KEY (`RUTA`),
  ADD KEY `VEHICULO` (`VEHICULO`);

--
-- Indices de la tabla `caja`
--
ALTER TABLE `caja`
  ADD PRIMARY KEY (`ID_CAJA`);

--
-- Indices de la tabla `circula`
--
ALTER TABLE `circula`
  ADD PRIMARY KEY (`ESTADO`),
  ADD KEY `MENU` (`MENU`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`CI`);

--
-- Indices de la tabla `compone`
--
ALTER TABLE `compone`
  ADD PRIMARY KEY (`MENU`),
  ADD KEY `VIANDA` (`VIANDA`);

--
-- Indices de la tabla `contiene`
--
ALTER TABLE `contiene`
  ADD PRIMARY KEY (`PUNTO_ENTREGA`),
  ADD KEY `RUTA` (`RUTA`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`ID_DEPARTAMENTO`);

--
-- Indices de la tabla `efectua`
--
ALTER TABLE `efectua`
  ADD PRIMARY KEY (`SUCURSAL`),
  ADD KEY `PRODUCCION` (`PRODUCCION`);

--
-- Indices de la tabla `empaca`
--
ALTER TABLE `empaca`
  ADD PRIMARY KEY (`CAJA`),
  ADD KEY `MENU` (`MENU`);

--
-- Indices de la tabla `entrega`
--
ALTER TABLE `entrega`
  ADD PRIMARY KEY (`VEHICULO`),
  ADD KEY `CLIENTE` (`CLIENTE`);

--
-- Indices de la tabla `esta`
--
ALTER TABLE `esta`
  ADD PRIMARY KEY (`DEPARTAMENTO`),
  ADD KEY `PUNTO_ENTREGA` (`PUNTO_ENTREGA`);

--
-- Indices de la tabla `estado`
--
ALTER TABLE `estado`
  ADD PRIMARY KEY (`ID_ESTADO`);

--
-- Indices de la tabla `genera`
--
ALTER TABLE `genera`
  ADD PRIMARY KEY (`PRODUCTO`),
  ADD KEY `PRODUCCION` (`PRODUCCION`);

--
-- Indices de la tabla `incluye`
--
ALTER TABLE `incluye`
  ADD PRIMARY KEY (`PEDIDO`),
  ADD KEY `CAJA` (`CAJA`);

--
-- Indices de la tabla `menu`
--
ALTER TABLE `menu`
  ADD PRIMARY KEY (`ID_MENU`);

--
-- Indices de la tabla `pedido`
--
ALTER TABLE `pedido`
  ADD PRIMARY KEY (`ID_PEDIDO`),
  ADD KEY `CI_CLIENTE` (`CI_CLIENTE`),
  ADD KEY `ESTADO` (`ESTADO`),
  ADD KEY `TIPO_MENU` (`TIPO_MENU`);

--
-- Indices de la tabla `pertenece`
--
ALTER TABLE `pertenece`
  ADD PRIMARY KEY (`SUCURSAL`),
  ADD KEY `VEHICULO` (`VEHICULO`);

--
-- Indices de la tabla `postre`
--
ALTER TABLE `postre`
  ADD PRIMARY KEY (`ID_POSTRE`);

--
-- Indices de la tabla `produccion`
--
ALTER TABLE `produccion`
  ADD PRIMARY KEY (`ID_PRODUCCION`);

--
-- Indices de la tabla `punto_entrega`
--
ALTER TABLE `punto_entrega`
  ADD PRIMARY KEY (`ID_PUNTOENTREGA`);

--
-- Indices de la tabla `realiza`
--
ALTER TABLE `realiza`
  ADD PRIMARY KEY (`CLIENTE`),
  ADD KEY `PEDIDO` (`PEDIDO`);

--
-- Indices de la tabla `reside`
--
ALTER TABLE `reside`
  ADD PRIMARY KEY (`DEPARTAMENTO`),
  ADD KEY `SUCURSAL` (`SUCURSAL`);

--
-- Indices de la tabla `ruta`
--
ALTER TABLE `ruta`
  ADD PRIMARY KEY (`ID_RUTA`);

--
-- Indices de la tabla `solicita`
--
ALTER TABLE `solicita`
  ADD PRIMARY KEY (`CLIENTE`),
  ADD KEY `MENU` (`MENU`);

--
-- Indices de la tabla `sucursal`
--
ALTER TABLE `sucursal`
  ADD PRIMARY KEY (`ID_SUCURSAL`);

--
-- Indices de la tabla `transita`
--
ALTER TABLE `transita`
  ADD PRIMARY KEY (`ESTADO`),
  ADD KEY `PEDIDO` (`PEDIDO`);

--
-- Indices de la tabla `transporta`
--
ALTER TABLE `transporta`
  ADD PRIMARY KEY (`PEDIDO`,`VEHICULO`),
  ADD KEY `VEHICULO` (`VEHICULO`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`CI`);

--
-- Indices de la tabla `vehiculo`
--
ALTER TABLE `vehiculo`
  ADD PRIMARY KEY (`ID_VEHICULO`);

--
-- Indices de la tabla `vianda`
--
ALTER TABLE `vianda`
  ADD PRIMARY KEY (`ID_VIANDA`),
  ADD KEY `ESTADO` (`ESTADO`);

--
-- Indices de la tabla `vive`
--
ALTER TABLE `vive`
  ADD PRIMARY KEY (`DEPARTAMENTO`),
  ADD KEY `CLIENTE` (`CLIENTE`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `caja`
--
ALTER TABLE `caja`
  MODIFY `ID_CAJA` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `departamento`
--
ALTER TABLE `departamento`
  MODIFY `ID_DEPARTAMENTO` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `estado`
--
ALTER TABLE `estado`
  MODIFY `ID_ESTADO` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de la tabla `menu`
--
ALTER TABLE `menu`
  MODIFY `ID_MENU` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT de la tabla `pedido`
--
ALTER TABLE `pedido`
  MODIFY `ID_PEDIDO` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT de la tabla `postre`
--
ALTER TABLE `postre`
  MODIFY `ID_POSTRE` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `produccion`
--
ALTER TABLE `produccion`
  MODIFY `ID_PRODUCCION` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `punto_entrega`
--
ALTER TABLE `punto_entrega`
  MODIFY `ID_PUNTOENTREGA` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `ruta`
--
ALTER TABLE `ruta`
  MODIFY `ID_RUTA` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `sucursal`
--
ALTER TABLE `sucursal`
  MODIFY `ID_SUCURSAL` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `vehiculo`
--
ALTER TABLE `vehiculo`
  MODIFY `ID_VEHICULO` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `vianda`
--
ALTER TABLE `vianda`
  MODIFY `ID_VIANDA` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `acompaña`
--
ALTER TABLE `acompaña`
  ADD CONSTRAINT `acompaña_ibfk_1` FOREIGN KEY (`POSTRE`) REFERENCES `postre` (`ID_POSTRE`),
  ADD CONSTRAINT `acompaña_ibfk_2` FOREIGN KEY (`VIANDA`) REFERENCES `vianda` (`ID_VIANDA`);

--
-- Filtros para la tabla `asigna`
--
ALTER TABLE `asigna`
  ADD CONSTRAINT `asigna_ibfk_1` FOREIGN KEY (`RUTA`) REFERENCES `ruta` (`ID_RUTA`),
  ADD CONSTRAINT `asigna_ibfk_2` FOREIGN KEY (`VEHICULO`) REFERENCES `vehiculo` (`ID_VEHICULO`);

--
-- Filtros para la tabla `circula`
--
ALTER TABLE `circula`
  ADD CONSTRAINT `circula_ibfk_1` FOREIGN KEY (`ESTADO`) REFERENCES `estado` (`ID_ESTADO`),
  ADD CONSTRAINT `circula_ibfk_2` FOREIGN KEY (`MENU`) REFERENCES `menu` (`ID_MENU`);

--
-- Filtros para la tabla `compone`
--
ALTER TABLE `compone`
  ADD CONSTRAINT `compone_ibfk_1` FOREIGN KEY (`MENU`) REFERENCES `menu` (`ID_MENU`),
  ADD CONSTRAINT `compone_ibfk_2` FOREIGN KEY (`VIANDA`) REFERENCES `vianda` (`ID_VIANDA`);

--
-- Filtros para la tabla `contiene`
--
ALTER TABLE `contiene`
  ADD CONSTRAINT `contiene_ibfk_1` FOREIGN KEY (`PUNTO_ENTREGA`) REFERENCES `punto_entrega` (`ID_PUNTOENTREGA`),
  ADD CONSTRAINT `contiene_ibfk_2` FOREIGN KEY (`RUTA`) REFERENCES `ruta` (`ID_RUTA`);

--
-- Filtros para la tabla `efectua`
--
ALTER TABLE `efectua`
  ADD CONSTRAINT `efectua_ibfk_1` FOREIGN KEY (`SUCURSAL`) REFERENCES `sucursal` (`ID_SUCURSAL`),
  ADD CONSTRAINT `efectua_ibfk_2` FOREIGN KEY (`PRODUCCION`) REFERENCES `produccion` (`ID_PRODUCCION`);

--
-- Filtros para la tabla `empaca`
--
ALTER TABLE `empaca`
  ADD CONSTRAINT `empaca_ibfk_1` FOREIGN KEY (`CAJA`) REFERENCES `caja` (`ID_CAJA`),
  ADD CONSTRAINT `empaca_ibfk_2` FOREIGN KEY (`MENU`) REFERENCES `menu` (`ID_MENU`);

--
-- Filtros para la tabla `entrega`
--
ALTER TABLE `entrega`
  ADD CONSTRAINT `entrega_ibfk_1` FOREIGN KEY (`VEHICULO`) REFERENCES `vehiculo` (`ID_VEHICULO`),
  ADD CONSTRAINT `entrega_ibfk_2` FOREIGN KEY (`CLIENTE`) REFERENCES `cliente` (`CI`);

--
-- Filtros para la tabla `esta`
--
ALTER TABLE `esta`
  ADD CONSTRAINT `esta_ibfk_1` FOREIGN KEY (`PUNTO_ENTREGA`) REFERENCES `punto_entrega` (`ID_PUNTOENTREGA`),
  ADD CONSTRAINT `esta_ibfk_2` FOREIGN KEY (`DEPARTAMENTO`) REFERENCES `departamento` (`ID_DEPARTAMENTO`);

--
-- Filtros para la tabla `genera`
--
ALTER TABLE `genera`
  ADD CONSTRAINT `genera_ibfk_1` FOREIGN KEY (`PRODUCTO`) REFERENCES `menu` (`ID_MENU`),
  ADD CONSTRAINT `genera_ibfk_2` FOREIGN KEY (`PRODUCCION`) REFERENCES `produccion` (`ID_PRODUCCION`);

--
-- Filtros para la tabla `incluye`
--
ALTER TABLE `incluye`
  ADD CONSTRAINT `incluye_ibfk_1` FOREIGN KEY (`CAJA`) REFERENCES `caja` (`ID_CAJA`),
  ADD CONSTRAINT `incluye_ibfk_2` FOREIGN KEY (`PEDIDO`) REFERENCES `pedido` (`ID_PEDIDO`);

--
-- Filtros para la tabla `pertenece`
--
ALTER TABLE `pertenece`
  ADD CONSTRAINT `pertenece_ibfk_1` FOREIGN KEY (`SUCURSAL`) REFERENCES `sucursal` (`ID_SUCURSAL`),
  ADD CONSTRAINT `pertenece_ibfk_2` FOREIGN KEY (`VEHICULO`) REFERENCES `vehiculo` (`ID_VEHICULO`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
