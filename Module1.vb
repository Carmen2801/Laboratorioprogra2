Module Module1
    Sub main()
        Ejercicio1()
        'Ejercicio2()
    End Sub
    Sub Ejercicio1()
        ' se ingresa el costo del articulo y la cantidad de dinero entregada por el cliente
        Console.Write("Ingrese el costo del artículo: ")
        Dim costo As Double = Double.Parse(Console.ReadLine())

        Console.Write("Ingrese la cantidad de dinero entregada por el cliente: ")
        Dim dineroEntregado As Double = Double.Parse(Console.ReadLine())

        ' Calcular el cambio del pago
        If dineroEntregado > costo Then
            Dim cambio As Double = dineroEntregado - costo
            Console.WriteLine($"Cambio a entregar: {cambio:C2}")
        ElseIf dineroEntregado = costo Then
            Console.WriteLine("Entrega del producto.")
        Else
            Console.WriteLine("El pago es insuficiente. Por favor, ingrese la cantidad restante.")
            Dim cantidadRestante As Double = costo - dineroEntregado
            Console.WriteLine($"Cantidad faltante: {cantidadRestante:C2}")
            Console.WriteLine("Lo sentimos, no podemos entregar el producto en este momento.")
            Console.WriteLine("Vuelva pronto por el producto que desea.")
        End If
        Console.WriteLine("Programa creado por [Maria Del Carmen]")
        Console.ReadLine()
    End Sub
    Sub Ejercicio2()

        Dim totalCompra As Decimal = 0
        Dim descuento As Decimal = 0
        Dim continuar As Boolean = True

        Console.WriteLine("Bienvenido")
        While continuar
            'se ingresa el monto de la compra
            Console.Write("Ingrese el monto de la compra (ingrese un número negativo para salir): ")
            Dim montoCompra As Decimal = Decimal.Parse(Console.ReadLine())

            If montoCompra < 0 Then
                continuar = False
            Else
                'si supera los 1000 se aplica un 10% de descuento
                totalCompra += montoCompra
                If totalCompra > 1000 Then
                    descuento = totalCompra * 0.1
                    'si supera los 500 se aplica un 5% de descuento
                ElseIf totalCompra > 500 Then
                    descuento = totalCompra * 0.05
                End If
                Console.WriteLine("Total de la compra: $" & totalCompra)
                Console.WriteLine("Descuento aplicado: $" & descuento)
                Console.WriteLine("Total a pagar: $" & (totalCompra - descuento))
            End If
        End While

        Console.WriteLine("Programa creado por [Maria Del Carmen]")


    End Sub
End Module
