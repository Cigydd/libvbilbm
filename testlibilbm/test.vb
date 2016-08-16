Imports libvbilbm
Imports libvbilbm.ifftypes
Imports libvbilbm.id


Module test

    Sub Main()

        IFFErrorTest()

        Console.WriteLine()

        IFFIdReadTest()

        Console.ReadLine()
    End Sub

    Sub IFFErrorTest()
        Console.WriteLine("IFF Error Test:")
        libvbilbm.ifferror.IFF_error("{0} {1}{2}", "Printout:", "Error test.", vbCrLf)
    End Sub

    Sub IFFIdReadTest()
        Console.WriteLine("ID Read Test:")
        Dim file As New BinaryFile("idtest.iff")
        Dim id As String = "    "
        Dim Result As Boolean
        Result = IFF_readId(file, id, "FORM", "FRML")
        Console.WriteLine("ID: {0}", id)
        Console.WriteLine("Result: {0}", Result)
    End Sub

End Module
