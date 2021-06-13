Algoritmo De1A5Y5A1
	Definir s, i, n , a Como Entero
	Definir sw Como Logica 
	
	s<-1
	i<-1
	a<-5
	sw<- Verdadero
	
	Leer n
	
	Mientras i<=n Hacer
		
		Mostrar s
		
		Si sw = Verdadero
			s<- s+1
			Si s =  a Entonces
				Mostrar s
				sw<-Falso
			FinSi
			
		SiNo
			s<-s-1
			Si s = 1 Entonces
				Mostrar s
				sw<-Verdadero
				a<-a-1
			FinSi
		FinSi

		i<-i+1
	FinMientras
FinAlgoritmo
