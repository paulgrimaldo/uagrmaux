Algoritmo repeticion4Termino
	Definir s, a, n,i Como Entero;
	Leer n;
	i<-1;
	s<-1;
	a<-1;
	
	Mientras i <= n
		Escribir s;
		Si a = 4
			a <- 0;
		SiNo
			s<-s+1;
		FinSi
		a<-a+1;
		i<-i+1;
	FinMientras
FinAlgoritmo
