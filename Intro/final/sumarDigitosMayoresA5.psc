Algoritmo SumaDigitosMayoresA5
	Definir x,y1,s,d Como Entero
	Leer x
	Leer y1
	Mientras x>0 Hacer
		d <- x mod 10
		x <- trunc(x/10)
		Si d>5 Entonces
			s <- s+d
		FinSi
	FinMientras
	Mientras y1>0 Hacer
		d <- y1 mod 10
		y1 <- trunc(y1 / 10)
		Si d>5 Entonces
			s <- s+d
		FinSi
	FinMientras
	Escribir s,d
FinAlgoritmo
