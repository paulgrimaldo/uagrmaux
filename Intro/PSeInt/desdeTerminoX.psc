Algoritmo desdeTerminoX
	Definir N, t, sum, x, a, c Como Entero
	sum <- 0; a <- 8; c <- 1;
	Escribir 'Cuantos terminos?:'
	Leer t
	Escribir 'Ultimo digito del registro? '
	Leer x
	N <- x
	Mientras c<=t Hacer
		Escribir 'Termino: ', N
		N <- N+a
		a <- a+1
		sum <- sum+N
		c <- c+1
	FinMientras
	Escribir 'Suma: ',sum
FinAlgoritmo
