Algoritmo SerieSumaEn2Y6
	Definir s, i, n, a1, a2, sg, sa Como Entero
	Definir sw Como Logico
	
	s<-1
	i<-1
	a1<-2
	a2<-6
	sg<-1
	sa<-1
	sw<-Verdadero
	Leer n
	
	Mientras  i<= n Hacer
		Mostrar sa
		Si sw = Verdadero
			s<-s+a1
			a1<-a1+2
			sw<-Falso
		SiNo
			s<-s+a2
			a2<-a2+6
			sw<-Verdadero
		FinSi
		
		sg<-sg * (-1)
		sa<-s *sg
		
		i<-i+1
	FinMientras
	
	
FinAlgoritmo
