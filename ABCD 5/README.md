# Actividad 5 - Ejercicio 5: Matriz 5x10 con Sumas y Promedios (Arreglos A, B, C, D)

## Datos de la Asignatura y Proyecto
- **Asignatura:** Estructura de Datos
- **Unidad I:** Conceptos básicos de estructuras de datos orientadas a objetos
- **Tema:** Práctica. Arreglos y Matrices Bidimensionales con POO

---

## 1. Descripción del Problema
Desarrollar una aplicación en C# bajo el paradigma de **Programación Orientada a Objetos (POO)** para llenar una matriz de **5 x 10** con números aleatorios y calcular la suma y promedio por cada fila y por cada columna, almacenándolos en arreglos independientes de la siguiente manera:
- **a)** La **suma de la primera fila** se almacena en la primera posición del **arreglo A** y el **promedio** en la primera posición del **arreglo B**, y así sucesivamente para las 5 filas ($i = 0 \dots 4$).
- **b)** La **suma de la primera columna** se almacena en la primera posición del **arreglo C** y el **promedio** en la primera posición del **arreglo D**, y así sucesivamente para las 10 columnas ($j = 0 \dots 9$).
- **c)** Imprimir la matriz y los resultados con el formato tabular estipulado en la Página 3 del PDF del instrumento de evaluación.

---

## 2. Análisis del Problema (Entradas, Proceso y Salida)

### A. Entradas
- **Matriz Bidimensional (5 filas $\times$ 10 columnas):**
  - Generación automática mediante números aleatorios con rango configurable ($RangoMínimo$ y $RangoMáximo$).
  - Opción de carga directa de la matriz de prueba oficial del PDF.
  - Edición manual interactiva celda por celda a través del `DataGridView`.
- **Validaciones de Entrada:**
  - Control de datos faltantes (*"Hay datos faltantes"*).
  - Control de tipos estrictamente numéricos decimales (*"Introducir sólo números"*).
  - Validación lógica ($RangoMínimo \le RangoMáximo$).
  - Captura y manejo de excepciones en edición de celdas.

### B. Proceso
1. **Llenado:** Asignar valores a cada celda $(i, j)$ donde $0 \le i < 5$ y $0 \le j < 10$.
2. **Cálculo de Filas (Arreglos A y B):**
   - Para cada fila $i$:
     $$A[i] = \sum_{j=0}^{9} \text{Matriz}[i, j]$$
     $$B[i] = \frac{A[i]}{10}$$
3. **Cálculo de Columnas (Arreglos C y D):**
   - Para cada columna $j$:
     $$C[j] = \sum_{i=0}^{4} \text{Matriz}[i, j]$$
     $$D[j] = \frac{C[j]}{5}$$

### C. Salida
- **Vista Gráfica (`dgvMatriz` y `dgvTotalesColumnas`):**
  - Matriz de 5x10 interactiva.
  - Columnas añadidas y resaltadas para **A (Suma Fila)** y **B (Promedio Fila)**.
  - Cuadrícula inferior sincronizada para **C (Suma Columna)** y **D (Promedio Columna)**.
- **Formato Impreso del PDF (Pestaña 2):**
  ```text
  Matriz (5x10)                                 A       B
  [ 2  4  5  1  2  1  1  4  4  2 ]             [ 26 ]  [ 2.6 ]
  [ 3  4  4  8  4  2  3  6  5  4 ]             [ 43 ]  [ 4.3 ]
  [ 5  2  9  4  6  7  7  8  4  8 ]             [ 60 ]  [ 6.0 ]
  [ 8  8  7  9  3  8  6  2  9  3 ]             [ 63 ]  [ 6.3 ]
  [ 9  4  2  6  1  5  2  7  2  5 ]             [ 43 ]  [ 4.3 ]
  C [ 27  22  27  28  16  23  19  27  24  22 ]
  D [ 5.4 4.4 5.4 5.6 3.2 4.6 3.8 5.4 4.8 4.4 ]
  ```

---

## 3. Arquitectura Orientada a Objetos (POO)
- **Modelo de Negocio (`MatrizEstadisticas.cs`):** Encapsulamiento de la matriz `decimal[,]`, los cuatro arreglos `decimal[] _arregloA`, `_arregloB`, `_arregloC`, `_arregloD`, algoritmos de cálculo, validación de rangos e índices, y formateador textual idéntico al PDF.
- **Capa de Presentación (`frmMatrizEstadisticas.cs` / `frmMatrizEstadisticas.Designer.cs`):** Formulario estandarizado con controles nombrados según las directrices (`lblTitulo`, `txtRangoMin`, `txtRangoMax`, `btnGenerarAleatorios`, `btnCargarEjemplo`, `btnCalcular`, `btnLimpiar`, `btnCopiarFormatoPdf`, `btnSalir`, `dgvMatriz`, `dgvTotalesColumnas`, `picLogo`).
- **Punto de Entrada (`Program.cs`):** Inicialización y arranque de la interfaz gráfica.
