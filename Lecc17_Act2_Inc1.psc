Algoritmo Lecc17_Act2_Inc1
	Definir numeroFila, numeroColumna Como Entero
	Definir matrizIdentidad Como Entero
	Dimensionar matrizIdentidad[4,4]
	
	Para numeroFila <- 1 Hasta 4 Hacer
		Para numeroColumna <- 1 Hasta 4 Hacer
			Si numeroFila = numeroColumna Entonces
				matrizIdentidad[numeroFila,numeroColumna]<-1
			SiNo
				matrizIdentidad[numeroFila,numeroColumna]<-0
			Fin Si
		Fin Para
	Fin Para
	
	Escribir "Matriz Identidad"
	Para numeroFila <- 1 Hasta 4 Hacer
		Para numeroColumna <- 1 Hasta 4 Hacer
			Escribir Sin Saltar matrizIdentidad[numeroFila,numeroColumna], " "
		FinPara
		Escribir " "
	FinPara
FinAlgoritmo
