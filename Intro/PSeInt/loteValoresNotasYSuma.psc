Algoritmo loteValoresNotasYSuma
	s <- 0
	Escribir 'Nota: '
	Leer N
	Mientras N>=0 Hacer
		Si N>=51 Entonces
			Escribir 'Nota Aprobada: ', N
		FinSi
		s <- s+N
		Escribir 'Nota: '
		Leer N
	FinMientras
	Escribir 'Suma: ', s
FinAlgoritmo
