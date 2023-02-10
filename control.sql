-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 10-02-2023 a las 05:35:24
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
-- Base de datos: `control`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `jjj` ()   select * from horarios$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `probar` (IN `codigo` VARCHAR(20))   select * from asistencia where  codigo_persona_as =codigo ORDER BY idasistencia DESC LIMIT 1$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_CONTARTARDE` ()   select count(*)AS total from asistencia where TardeTemprano='Tarde'$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_TARDANZA` (IN `codigo_persona` VARCHAR(20))   select u.idhorario,u.codigo_persona,h.horaentrada from usuarios u inner JOIN horarios h on u.idhorario=h.idhorario where u.codigo_persona=codigo_persona$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_TEMPRANO` ()   select count(*) from asistencia where TardeTemprano='Temprano'$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ULTIMOREGISTROENTRADA` (IN `codigo` VARCHAR(20))   select * from asistencia where codigo_persona_as=codigo and tipo='entrada'  ORDER BY idasistencia DESC LIMIT 1$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_ULTIMOREGISTROSALIDA` (IN `codigo` VARCHAR(20))   select * from asistencia where codigo_persona_as=codigo and tipo='salida'  ORDER BY idasistencia DESC LIMIT 1$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asistencia`
--

CREATE TABLE `asistencia` (
  `idasistencia` int(11) NOT NULL,
  `codigo_persona_as` varchar(20) COLLATE utf8_bin NOT NULL,
  `fecha_hora` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `tipo` varchar(45) COLLATE utf8_bin NOT NULL,
  `fecha` date NOT NULL,
  `TardeTemprano` varchar(80) COLLATE utf8_bin DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `asistencia`
--

INSERT INTO `asistencia` (`idasistencia`, `codigo_persona_as`, `fecha_hora`, `tipo`, `fecha`, `TardeTemprano`) VALUES
(571, '2fBrgx', '2023-01-12 03:57:14', 'entrada', '2023-01-11', 'Tarde'),
(572, 'c29Z87', '2023-01-12 04:00:12', 'entrada', '2023-01-11', 'Tarde'),
(573, 'ZEPw6i', '2023-01-12 04:05:56', 'entrada', '2023-01-11', 'Temprano'),
(574, 'ZEPw6i', '2023-01-16 01:20:18', 'entrada', '2023-01-15', 'Temprano'),
(575, 'ZEPw6i', '2023-01-16 03:45:01', 'salida', '2023-01-15', NULL),
(576, '2fBrgx', '2023-01-25 20:22:42', 'entrada', '2023-01-25', 'Tarde'),
(577, '2fBrgx', '2023-01-25 20:23:02', 'salida', '2023-01-25', NULL),
(578, 'ZEPw6i', '2023-01-25 20:24:23', 'entrada', '2023-01-25', 'Temprano'),
(579, 'ZEPw6i', '2023-01-26 00:13:16', 'salida', '2023-01-25', NULL),
(580, 'ZEPw6i', '2023-01-27 12:17:59', 'entrada', '2023-01-27', 'Temprano'),
(581, 'ZEPw6i', '2023-01-28 16:17:20', 'entrada', '2023-01-28', 'Temprano');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

CREATE TABLE `departamento` (
  `iddepartamento` int(11) NOT NULL,
  `nombre` varchar(45) COLLATE utf8_bin NOT NULL,
  `descripcion` varchar(45) COLLATE utf8_bin NOT NULL,
  `fechacreada` datetime NOT NULL,
  `idusuario` varchar(45) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `departamento`
--

INSERT INTO `departamento` (`iddepartamento`, `nombre`, `descripcion`, `fechacreada`, `idusuario`) VALUES
(1, 'Analista de créditos  ', 'asesor de ventas', '2020-09-13 22:41:44', '64'),
(2, 'Promotor de ahorro y crédito', 'trabajo de promoción', '2020-01-19 00:15:24', '1'),
(3, 'Gerencia', 'representante legal', '2020-01-28 21:24:52', '1'),
(4, 'Administración', 'encargado de agencia', '2020-01-28 21:25:08', '1'),
(5, 'Recibidor(a)/Pagador(a)', 'encargado de los movimientos de caja', '2020-01-28 21:25:45', '1'),
(6, 'Vigilancia', 'vigilante diurno', '2020-01-28 21:26:14', '1'),
(7, 'Limpieza', 'encargado de la limpieza de oficinas', '2020-01-28 21:26:50', '1'),
(8, 'ingenieria informatico', 'hace genialidades', '2020-08-23 20:47:31', '16'),
(9, 'ingeniero quimicos', 'ver los residuos quimicos', '2023-01-28 12:32:22', '99'),
(10, 'bioquimica', 'estudio humano', '2020-08-30 23:43:03', ''),
(11, 'electricidad', 'estudio de atomos', '2020-08-30 23:46:10', '64'),
(12, 'Analista de créditos ', 'asesor de ventass', '2020-09-13 22:17:57', '64'),
(13, 'Analista de créditos ', 'asesor de ventass', '2020-09-13 22:18:12', '64'),
(14, 'Promotor de ahorro y crédito ', 'trabajo de promociónn', '2020-09-13 22:21:00', '64'),
(15, 'Analista de créditos ', 'asesor de ventass', '2020-09-13 22:22:58', '64'),
(16, 'Analista de créditos ', 'asesor de ventasss', '2020-09-13 22:24:23', '64'),
(19, ' nasa ', 'estudiar al mundos', '2023-01-28 12:18:00', '99');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `horarios`
--

CREATE TABLE `horarios` (
  `idhorario` int(11) NOT NULL,
  `horaentrada` time DEFAULT NULL,
  `horasalida` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `horarios`
--

INSERT INTO `horarios` (`idhorario`, `horaentrada`, `horasalida`) VALUES
(1, '09:30:00', '13:00:00'),
(2, '08:00:00', '13:00:00'),
(3, '23:30:00', '00:00:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mensajes`
--

CREATE TABLE `mensajes` (
  `idmensaje` int(11) NOT NULL,
  `idusuariomensaje` int(11) NOT NULL,
  `textomensaje` text COLLATE utf8_bin NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1,
  `fechamensaje` datetime NOT NULL,
  `fechacreada` datetime NOT NULL,
  `idusuario` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipousuario`
--

CREATE TABLE `tipousuario` (
  `idtipousuario` int(11) NOT NULL,
  `nombre` varchar(45) COLLATE utf8_bin NOT NULL,
  `descripcion` varchar(45) COLLATE utf8_bin NOT NULL,
  `fechacreada` datetime NOT NULL,
  `idusuario` varchar(45) COLLATE utf8_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `tipousuario`
--

INSERT INTO `tipousuario` (`idtipousuario`, `nombre`, `descripcion`, `fechacreada`, `idusuario`) VALUES
(1, 'Administrador', 'Con priviliegios de gestionar todo el sistema', '2020-01-18 00:00:00', '1'),
(2, 'Vendedor', 'vende y promueve los productos', '2020-09-15 11:27:22', '64'),
(3, 'administrador2', 'hace lo mismo que el administrador', '2020-08-23 20:46:07', '16'),
(5, 'administrador3', 'todo', '2023-01-28 12:40:42', '99');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `idusuario` int(11) NOT NULL,
  `nombre_usuario` varchar(45) COLLATE utf8_bin NOT NULL,
  `apellidos` varchar(45) COLLATE utf8_bin NOT NULL,
  `login` varchar(45) COLLATE utf8_bin NOT NULL,
  `iddepartamento` int(11) NOT NULL,
  `idtipousuario` int(11) NOT NULL,
  `email` varchar(45) COLLATE utf8_bin NOT NULL,
  `password` varchar(64) COLLATE utf8_bin NOT NULL,
  `imagen` varchar(200) COLLATE utf8_bin DEFAULT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT 1,
  `fechacreado` datetime DEFAULT NULL,
  `usuariocreado` varchar(45) COLLATE utf8_bin NOT NULL,
  `codigo_persona` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `idmensaje` int(11) NOT NULL,
  `idhorario` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`idusuario`, `nombre_usuario`, `apellidos`, `login`, `iddepartamento`, `idtipousuario`, `email`, `password`, `imagen`, `estado`, `fechacreado`, `usuariocreado`, `codigo_persona`, `idmensaje`, `idhorario`) VALUES
(95, 'amados', 'cruz', 'genioee', 12, 1, 'wendy145@gmail,com', '123', 'excel.png', 2, '2023-01-28 12:37:31', '', '2fBrgx', 0, 2),
(99, 'karlasss', 'ayllon', 'karlass', 1, 1, 'jairo.josias14@gmail.com', '123', 'fondo_linkendin.jpg', 2, '2023-01-12 00:05:36', '', 'c29Z87', 0, 1),
(100, 'yeren', 'ayllon', 'josias', 1, 1, 'jairo.josias14@gmail.com', '123', 'html.png', 2, '2023-01-11 23:05:26', '', 'ZEPw6i', 0, 3),
(102, 'luna', 'ayllon', 'luna', 7, 2, 'wendy145@gmail,com', '123', 'fondo_imagen_sistema.jpg', 2, '2023-01-28 12:31:36', '', 'bMqe6E', 0, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `asistencia`
--
ALTER TABLE `asistencia`
  ADD PRIMARY KEY (`idasistencia`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`iddepartamento`);

--
-- Indices de la tabla `horarios`
--
ALTER TABLE `horarios`
  ADD PRIMARY KEY (`idhorario`);

--
-- Indices de la tabla `mensajes`
--
ALTER TABLE `mensajes`
  ADD PRIMARY KEY (`idmensaje`),
  ADD KEY `idusuario` (`idusuario`);

--
-- Indices de la tabla `tipousuario`
--
ALTER TABLE `tipousuario`
  ADD PRIMARY KEY (`idtipousuario`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`idusuario`),
  ADD UNIQUE KEY `login` (`login`),
  ADD UNIQUE KEY `codigo_persona` (`codigo_persona`),
  ADD KEY `fk_departamento` (`iddepartamento`),
  ADD KEY `fk_tiposusario` (`idtipousuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `asistencia`
--
ALTER TABLE `asistencia`
  MODIFY `idasistencia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=582;

--
-- AUTO_INCREMENT de la tabla `departamento`
--
ALTER TABLE `departamento`
  MODIFY `iddepartamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT de la tabla `horarios`
--
ALTER TABLE `horarios`
  MODIFY `idhorario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `mensajes`
--
ALTER TABLE `mensajes`
  MODIFY `idmensaje` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `tipousuario`
--
ALTER TABLE `tipousuario`
  MODIFY `idtipousuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `idusuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=103;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `mensajes`
--
ALTER TABLE `mensajes`
  ADD CONSTRAINT `mensajes_ibfk_1` FOREIGN KEY (`idusuario`) REFERENCES `usuarios` (`idusuario`);

--
-- Filtros para la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`iddepartamento`) REFERENCES `departamento` (`iddepartamento`),
  ADD CONSTRAINT `usuarios_ibfk_2` FOREIGN KEY (`idtipousuario`) REFERENCES `tipousuario` (`idtipousuario`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
