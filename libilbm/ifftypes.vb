Public Module ifftypes
    Public Const IFF_ID_SIZE = 4
    Public IFF_BIG_ENDIAN As Boolean = True

    Public Property IFF_Endianness As Endianness
        Get
            If IFF_BIG_ENDIAN Then
                Return libvbilbm.Endianness.endBig
            Else
                Return libvbilbm.Endianness.endLittle
            End If
        End Get
        Set(ByVal value As Endianness)
            If value = libvbilbm.Endianness.endBig Then
                IFF_BIG_ENDIAN = True
            Else
                IFF_BIG_ENDIAN = False
            End If
        End Set
    End Property
End Module

