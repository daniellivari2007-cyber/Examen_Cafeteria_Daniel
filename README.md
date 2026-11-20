# Examen Práctico - Cafetería "El Buen Sabor"

## 1. Nombre y matrícula
- **Nombre:** Daniel Livari Sanchez
- **Matrícula:** 2025-3676

## 2. Descripción del programa
Aplicación de escritorio en Windows Forms (C#) que permite registrar pedidos de clientes en la cafetería "El Buen Sabor", calcular recargos por tamaño y porción extra, aplicar descuentos y empaque, y obtener el total a pagar con ITBIS.

## 3. Datos de entrada
- Nombre del cliente (`txtCliente`) y estado de cliente frecuente (`chkFrecuente`).
- Fecha del pedido (`dtpFecha`).
- Nombre del producto (`txtProducto`), precio base (`txtPrecio`) y cantidad (`nudCantidad` de 1 a 20).
- Tamaño (`rbtNormal` o `rbtGrande`), porción extra (`chkPorcionExtra`) y tipo de servicio (`rbtLocal` o `rbtLlevar`).

## 4. Proceso
- Al cargar el formulario (`Load`), se inicializan controles, columnas y totales en `RD$ 0.00`.
- Al agregar (`btnAgregar`), se calcula el precio unitario y total de línea, se formatea en columnas con `PadRight`/`PadLeft` y se acumula el subtotal.
- Al calcular (`btnCalcular`), se valida que existan líneas y se calcula descuento (10% si es frecuente), empaque (RD$ 20 si es para llevar), base imponible, ITBIS (18%) y total a pagar.
- Al limpiar (`btnLimpiar`), se reinicia el pedido y se enfoca `txtCliente`.
- Al salir (`btnSalir`), se solicita confirmación `Sí/No` antes de cerrar.

## 5. Salida
- Listado detallado de líneas en `lstPedido` alineado con `lblEncabezado`.
- Resumen financiero en `lblSubtotal`, `lblDescuento`, `lblEmpaque`, `lblItbis` y `lblTotal` con formato `RD$ 0.00`.

## 6. Capturas de pantalla del programa en ejecución
<img width="790" height="476" alt="image" src="https://github.com/user-attachments/assets/e3798ac9-44ef-4803-827b-5a6280f47471" />

