# Actividad 4 - Ejercicio 4: Matriz Diagonal Cuadrada (1's y 0's)

## Datos de la Asignatura y Proyecto
- **Asignatura:** Estructura de Datos
- **Unidad I:** Conceptos básicos de estructuras de datos orientadas a objetos
- **Tema:** Práctica. Arreglos Bidimensionales (Matrices)

---

## 1. Descripción del Problema
Desarrollar una aplicación en C# bajo el paradigma de **Programación Orientada a Objetos (POO)** para llenar una matriz cuadrada ($N \times N$) de números enteros de manera que:
- a) La **diagonal principal** contenga `1`'s (unos).
- b) Las **demás posiciones** contengan `0`'s (ceros).

---

## 2. Análisis del Problema (Entradas, Proceso y Salida)

### A. Entradas
- **Dimensión de la matriz ($N$):** Número entero que representa tanto el número de filas como de columnas ($N \times N$).
- **Validaciones:**
  - Campo no vacío (*"Hay datos faltantes"*).
  - Formato estrictamente numérico (*"Introducir sólo números"*).
  - Número entero (no se permiten decimales como tamaño de matriz).
  - Rango permitido: $2 \le N \le 20$.

### B. Proceso
1. Inicializar la matriz cuadrada bidimensional de tamaño $N \times N$.
2. Recorrer la matriz mediante dos bucles anidados:
   - Para $i = 0$ hasta $N - 1$ (filas):
     - Para $j = 0$ hasta $N - 1$ (columnas):
       - Si $i == j$ (pertenece a la diagonal principal): asignar `1`.
       - De lo contrario ($i \ne j$): asignar `0`.
3. Contabilizar estadísticas:
   - Elementos en diagonal principal: $N$
   - Elementos fuera de la diagonal: $(N \times N) - N$
   - Total de elementos: $N^2$

### C. Salida
- Despliegue interactivo en un control `DataGridView` (`dgvMatriz`).
- Resaltado estético y condicional de la diagonal principal (celdas en color verde esmeralda con texto en negrita).
- Resumen estadístico textual (`lblEstadisticas`).
- Opción para copiar la matriz en formato de texto plano estructurado.

---

## 3. Arquitectura Orientada a Objetos (POO)
- **Modelo de Negocio (`MatrizDiagonal.cs`):** Encapsula la matriz bidimensional (`int[,] _matriz`), la dimensión (`_dimension`), métodos de llenado, verificación de diagonal (`EsDiagonalPrincipal`), redimensionamiento y generación de texto.
- **Capa de Presentación (`frmMatrizDiagonal.cs` / `frmMatrizDiagonal.Designer.cs`):** Formulario Windows Forms estandarizado con controles según la nomenclatura exigida (`lblTitulo`, `txtDimension`, `btnGenerarMatriz`, `btnLimpiar`, `btnSalir`, `dgvMatriz`, `picLogo`).
- **Punto de Entrada (`Program.cs`):** Inicialización de la aplicación Windows Forms.
