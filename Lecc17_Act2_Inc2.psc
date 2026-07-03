Algoritmo Lecc17_Act2_Inc2	
	Definir numeroFila, numeroColumna Como Entero
	Definir matrizColumnas Como Entero
	Dimensionar matrizColumnas[4,4]
	
	Para numeroFila <-1 Hasta 4 Hacer
		Para numeroColumna <-1 Hasta 4 Hacer
			matrizColumnas[numeroFila,numeroColumna] <- numeroColumna
		Fin Para
	Fin Para
	
	Escribir "Matriz Columnas"
	Para numeroFila <- 1 Hasta 4 Hacer
		Para numeroColumna <- 1 Hasta  4 Hacer
			Escribir Sin Saltar matrizColumnas[numeroFila,numeroColumna]," "
		FinPara
		Escribir " "
	Fin Para
FinAlgoritmo
