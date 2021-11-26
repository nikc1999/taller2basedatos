CREATE TABLE contrasena(
    contra varchar(255)
    );
    
INSERT INTO contrasena
  (contra) 
VALUES 
  ("soyadmin");
  
DELETE FROM test1.actor WHERE LugarNacimiento = "santiago de chile";

SELECT * FROM actua JOIN pelicula ON actua.PeliculaTitulo = pelicula.titulo JOIN actor ON actor.Nombre = actua.ActorNombre WHERE PeliculaTitulo = 'red notice';

SELECT PeliculaTitulo, COUNT(*) FROM arriendo WHERE FechaArriendo >= date(sysdate())- interval weekday((sysdate())) day GROUP BY PeliculaTitulo ORDER BY 2 desc limit 5;