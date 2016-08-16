Module iffio

    '=============
    ' libiff/io.h
    '=============

    '/*
    ' * Copyright (c) 2012 Sander van der Burg
    ' *
    ' * Permission is hereby granted, free of charge, to any person obtaining a copy of
    ' * this software and associated documentation files (the "Software"), to deal in
    ' * the Software without restriction, including without limitation the rights to
    ' * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
    ' * the Software, and to permit persons to whom the Software is furnished to do so, 
    ' * subject to the following conditions:
    ' *
    ' * The above copyright notice and this permission notice shall be included in all
    ' * copies or substantial portions of the Software.
    ' *
    ' * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    ' * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
    ' * FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
    ' * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
    ' * IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
    ' * CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
    ' */

    '#ifndef __IFF_IO_H
    '#define __IFF_IO_H

    '#include <stdio.h>
    '#include "ifftypes.h"

    '#ifdef __cplusplus
    'extern "C" {
    '#endif

    '/**
    ' * Reads an unsigned byte from a file.
    ' *
    ' * @param file File descriptor of the file
    ' * @param value Value read from the file
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @param attributeName The name of the attribute that is examined (used for error reporting)
    ' * @return TRUE if the value has been successfully read, else FALSE
    ' */
    'int IFF_readUByte(FILE *file, IFF_UByte *value, const IFF_ID chunkId, const char *attributeName);

    '/**
    ' * Writes an unsigned byte to a file.
    ' *
    ' * @param file File descriptor of the file
    ' * @param value Value written to the file
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @param attributeName The name of the attribute that is examined (used for error reporting)
    ' * @return TRUE if the value has been successfully written, else FALSE
    ' */
    'int IFF_writeUByte(FILE *file, const IFF_UByte value, const IFF_ID chunkId, const char *attributeName);

    '/**
    ' * Reads an unsigned word from a file.
    ' *
    ' * @param file File descriptor of the file
    ' * @param value Value read from the file
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @param attributeName The name of the attribute that is examined (used for error reporting)
    ' * @return TRUE if the value has been successfully read, else FALSE
    ' */
    'int IFF_readUWord(FILE *file, IFF_UWord *value, const IFF_ID chunkId, const char *attributeName);

    '/**
    ' * Writes an unsigned word to a file.
    ' *
    ' * @param file File descriptor of the file
    ' * @param value Value written to the file
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @param attributeName The name of the attribute that is examined (used for error reporting)
    ' * @return TRUE if the value has been successfully written, else FALSE
    ' */
    'int IFF_writeUWord(FILE *file, const IFF_UWord value, const IFF_ID chunkId, const char *attributeName);

    '/**
    ' * Reads a signed word from a file.
    ' *
    ' * @param file File descriptor of the file
    ' * @param value Value read from the file
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @param attributeName The name of the attribute that is examined (used for error reporting)
    ' * @return TRUE if the value has been successfully read, else FALSE
    ' */
    'int IFF_readWord(FILE *file, IFF_Word *value, const IFF_ID chunkId, const char *attributeName);

    '/**
    ' * Writes a signed word to a file.
    ' *
    ' * @param file File descriptor of the file
    ' * @param value Value written to the file
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @param attributeName The name of the attribute that is examined (used for error reporting)
    ' * @return TRUE if the value has been successfully written, else FALSE
    ' */
    'int IFF_writeWord(FILE *file, const IFF_Word value, const IFF_ID chunkId, const char *attributeName);

    '/**
    ' * Reads an unsigned long from a file.
    ' *
    ' * @param file File descriptor of the file
    ' * @param value Value read from the file
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @param attributeName The name of the attribute that is examined (used for error reporting)
    ' * @return TRUE if the value has been successfully read, else FALSE
    ' */
    'int IFF_readULong(FILE* file, IFF_ULong *value, const IFF_ID chunkId, const char *attributeName);

    '/**
    ' * Writes an unsigned long to a file.
    ' *
    ' * @param file File descriptor of the file
    ' * @param value Value read from the file
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @param attributeName The name of the attribute that is examined (used for error reporting)
    ' * @return TRUE if the value has been successfully written, else FALSE
    ' */
    'int IFF_writeULong(FILE* file, const IFF_ULong value, const IFF_ID chunkId, const char *attributeName);

    '/**
    ' * Reads a signed long from a file.
    ' *
    ' * @param file File descriptor of the file
    ' * @param value Value read from the file
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @param attributeName The name of the attribute that is examined (used for error reporting)
    ' * @return TRUE if the value has been successfully read, else FALSE
    ' */
    'int IFF_readLong(FILE* file, IFF_Long *value, const IFF_ID chunkId, const char *attributeName);

    '/**
    ' * Writes a signed long to a file.
    ' *
    ' * @param file File descriptor of the file
    ' * @param value Value read from the file
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @param attributeName The name of the attribute that is examined (used for error reporting)
    ' * @return TRUE if the value has been successfully written, else FALSE
    ' */
    'int IFF_writeLong(FILE* file, const IFF_Long value, const IFF_ID chunkId, const char *attributeName);

    '/**
    ' * Reads a padding byte from a chunk with an odd size.
    ' *
    ' * @param file File descriptor of the file
    ' * @param chunkSize Size of the chunk in bytes
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @return TRUE if the byte has been successfully read, else FALSE
    ' */
    'int IFF_readPaddingByte(FILE *file, const IFF_Long chunkSize, const IFF_ID chunkId);

    '/**
    ' * Writes a padding byte to a chunk with an odd size.
    ' *
    ' * @param file File descriptor of the file
    ' * @param chunkSize Size of the chunk in bytes
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @return TRUE if the byte has been successfully written, else FALSE
    ' */
    'int IFF_writePaddingByte(FILE *file, const IFF_Long chunkSize, const IFF_ID chunkId);

    '#ifdef __cplusplus
    '}
    '#endif

    '#endif

    '=============
    ' libiff/io.c
    '=============

    '/*
    ' * Copyright (c) 2012 Sander van der Burg
    ' *
    ' * Permission is hereby granted, free of charge, to any person obtaining a copy of
    ' * this software and associated documentation files (the "Software"), to deal in
    ' * the Software without restriction, including without limitation the rights to
    ' * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
    ' * the Software, and to permit persons to whom the Software is furnished to do so, 
    ' * subject to the following conditions:
    ' *
    ' * The above copyright notice and this permission notice shall be included in all
    ' * copies or substantial portions of the Software.
    ' *
    ' * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    ' * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
    ' * FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
    ' * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
    ' * IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
    ' * CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
    ' */

    '#include "StdAfx.h"
    '#include "io.h"
    '#include "error.h"

    'int IFF_readUByte(FILE *file, IFF_UByte *value, const IFF_ID chunkId, const char *attributeName)
    Public Function IFF_readUByte(ByVal file As BinaryFile, ByRef value As Byte, _
                                  ByVal chunkId As String, ByVal attributeName As String) As Boolean
        '{


        '    int byte = fgetc(file);


        '    if(byte == EOF)
        '    {
        '	IFF_readError(chunkId, attributeName);
        '	return FALSE;
        '    }
        '    else
        '    {
        '	*value = byte;
        '	return TRUE;
        '    }
        Try
            value = file.ReadByteUnsigned
            Return True
        Catch ex As Exception
            IFF_readError(chunkId, attributeName)
            Return False
        End Try
        '}
    End Function

    'int IFF_writeUByte(FILE *file, const IFF_UByte value, const IFF_ID chunkId, const char *attributeName)
    Public Function IFF_writeUByte(ByVal file As BinaryFile, ByVal value As Byte, _
                                   ByVal chunkId As String, ByVal attributeName As String) As Boolean
        '{
        '    if(fputc(value, file) == EOF)
        '    {
        '	IFF_writeError(chunkId, attributeName);
        '	return FALSE;
        '    }
        '    else
        '	return TRUE;
        Try
            file.WriteByteUnsigned(value)
            Return True
        Catch ex As Exception
            IFF_writeError(chunkId, attributeName)
            Return False
        End Try
        '}
    End Function

    'int IFF_readUWord(FILE *file, IFF_UWord *value, const IFF_ID chunkId, const char *attributeName)
    Public Function IFF_readUWord(ByVal file As BinaryFile, ByRef value As UShort, _
                                  ByVal chunkID As String, ByVal attributeName As String) As Boolean
        '{
        '    IFF_UWord readUWord;

        '    if(fread(&readUWord, sizeof(IFF_UWord), 1, file) == 1)
        '    {
        '#ifdef IFF_BIG_ENDIAN
        '	*value = readUWord;
        '#else
        '	/* Byte swap it */
        '	*value = (readUWord & 0xff) << 8 | (readUWord & 0xff00) >> 8;
        '#End If

        '	return TRUE;
        '    }
        '    else
        '    {
        '	IFF_readError(chunkId, attributeName);
        '	return FALSE;
        '    }
        Try
            value = file.ReadWordUnsigned(IFF_Endianness)
            Return True
        Catch ex As Exception
            IFF_readError(chunkID, attributeName)
            Return False
        End Try
        '}
    End Function

    'int IFF_writeUWord(FILE *file, const IFF_UWord value, const IFF_ID chunkId, const char *attributeName)
    Public Function IFF_writeUWord(ByVal file As BinaryFile, ByVal value As UShort, _
                                   ByVal chunkId As String, ByVal attributeName As String) As Boolean
        '{
        '#ifdef IFF_BIG_ENDIAN
        '    IFF_UWord writeUWord = value;
        '#else
        '    /* Byte swap it */
        '    IFF_UWord writeUWord = (value & 0xff) << 8 | (value & 0xff00) >> 8;
        '#End If

        '    if(fwrite(&writeUWord, sizeof(IFF_UWord), 1, file) == 1)
        '	return TRUE;
        '    else
        '    {
        '	IFF_writeError(chunkId, attributeName);
        '	return FALSE;
        '    }
        Try
            file.WriteWordUnsigned(value, IFF_Endianness)
            Return True
        Catch ex As Exception
            IFF_writeError(chunkId, attributeName)
            Return False
        End Try
        '}
    End Function

    'int IFF_readWord(FILE *file, IFF_Word *value, const IFF_ID chunkId, const char *attributeName)
    Public Function IFF_readWord(ByVal file As BinaryFile, ByRef value As Short, _
                                 ByVal chunkId As String, ByVal attributeName As String) As Boolean
        '{
        '    IFF_Word readWord;

        '    if(fread(&readWord, sizeof(IFF_Word), 1, file) == 1)
        '    {
        '#ifdef IFF_BIG_ENDIAN
        '	*value = readWord;
        '#else
        '	/* Byte swap it */
        '	*value = (readWord & 0xff) << 8 | (readWord & 0xff00) >> 8;
        '#End If
        '	return TRUE;
        '    }
        '    else
        '    {
        '	IFF_readError(chunkId, attributeName);
        '	return FALSE;
        '    }
        Try
            value = file.ReadWordSigned(IFF_Endianness)
            Return True
        Catch ex As Exception
            IFF_readError(chunkId, attributeName)
            Return False
        End Try
        '}
    End Function

    'int IFF_writeWord(FILE *file, const IFF_Word value, const IFF_ID chunkId, const char *attributeName)
    Public Function IFF_writeWord(ByVal file As BinaryFile, ByVal value As Short, _
                                  ByVal chunkId As String, ByVal attributeName As String) As Boolean
        '{
        '#ifdef IFF_BIG_ENDIAN
        '    IFF_Word writeWord = value;
        '#else
        '    IFF_Word writeWord = (value & 0xff) << 8 | (value & 0xff00) >> 8;
        '#End If

        '    if(fwrite(&writeWord, sizeof(IFF_Word), 1, file) == 1)
        '	return TRUE;
        '    else
        '    {
        '	IFF_writeError(chunkId, attributeName);
        '	return FALSE;
        '    }
        Try
            file.WriteWordSigned(value, IFF_Endianness)
            Return True
        Catch ex As Exception
            IFF_readError(chunkId, attributeName)
            Return False
        End Try
        '}
    End Function

    'int IFF_readULong(FILE* file, IFF_ULong *value, const IFF_ID chunkId, const char *attributeName)
    Public Function IFF_readULong(ByVal file As BinaryFile, ByRef value As UInteger, _
                                  ByVal chunkId As String, ByVal attributeName As String) As Boolean
        '{
        '    IFF_ULong readValue;

        '    if(fread(&readValue, sizeof(IFF_ULong), 1, file) == 1)
        '    {
        '#ifdef IFF_BIG_ENDIAN
        '	*value = readValue;
        '#else
        '	/* Byte swap it */
        '	*value = (readValue & 0xff) << 24 | (readValue & 0xff00) << 8 | (readValue & 0xff0000) >> 8 | (readValue & 0xff000000) >> 24;
        '#End If
        '	return TRUE;
        '    }
        '    else
        '    {
        '	IFF_readError(chunkId, attributeName);
        '	return FALSE;
        '    }
        Try
            value = file.ReadLongwordUnsigned(IFF_Endianness)
            Return True
        Catch ex As Exception
            IFF_readError(chunkId, attributeName)
            Return False
        End Try
        '}
    End Function

    'int IFF_writeULong(FILE *file, const IFF_ULong value, const IFF_ID chunkId, const char *attributeName)
    Public Function IFF_writeULong(ByVal file As BinaryFile, ByVal value As UInteger, _
                                   ByVal chunkId As String, ByVal attributeName As String) As Boolean
        '{
        '#ifdef IFF_BIG_ENDIAN
        '    IFF_ULong writeValue = value;
        '#else
        '    /* Byte swap it */
        '    IFF_ULong writeValue = (value & 0xff) << 24 | (value & 0xff00) << 8 | (value & 0xff0000) >> 8 | (value & 0xff000000) >> 24;
        '#End If

        '    if(fwrite(&writeValue, sizeof(IFF_ULong), 1, file) == 1)
        '	return TRUE;
        '    else
        '    {
        '	IFF_writeError(chunkId, attributeName);
        '	return FALSE;
        '    }
        Try
            file.WriteLongwordUnsigned(value, IFF_Endianness)
            Return True
        Catch ex As Exception
            IFF_writeError(chunkId, attributeName)
            Return False
        End Try
        '}
    End Function

    'int IFF_readLong(FILE* file, IFF_Long *value, const IFF_ID chunkId, const char *attributeName)
    Public Function IFF_readLong(ByVal file As BinaryFile, ByRef value As Integer, _
                                 ByVal chunkId As String, ByVal attributeName As String) As Boolean
        '{
        '    IFF_Long readValue;

        '    if(fread(&readValue, sizeof(IFF_Long), 1, file) == 1)
        '    {
        '#ifdef IFF_BIG_ENDIAN
        '	*value = readValue;
        '#else
        '	/* Byte swap it */
        '	*value = (readValue & 0xff) << 24 | (readValue & 0xff00) << 8 | (readValue & 0xff0000) >> 8 | (readValue & 0xff000000) >> 24;
        '#End If
        '	return TRUE;
        '    }
        '    else
        '    {
        '	IFF_readError(chunkId, attributeName);
        '	return FALSE;
        '    }
        Try
            value = file.ReadLongwordSigned(IFF_Endianness)
            Return True
        Catch ex As Exception
            IFF_readError(chunkId, attributeName)
            Return False
        End Try
        '}
    End Function

    'int IFF_writeLong(FILE *file, const IFF_Long value, const IFF_ID chunkId, const char *attributeName)
    Public Function IFF_WriteLong(ByVal file As BinaryFile, ByVal value As Integer, _
                                  ByVal chunkId As String, ByVal attributeName As String) As Boolean
        '{
        '#ifdef IFF_BIG_ENDIAN
        '    IFF_Long writeValue = value;
        '#else
        '    /* Byte swap it */
        '    IFF_Long writeValue = (value & 0xff) << 24 | (value & 0xff00) << 8 | (value & 0xff0000) >> 8 | (value & 0xff000000) >> 24;
        '#End If

        '    if(fwrite(&writeValue, sizeof(IFF_Long), 1, file) == 1)
        '	return TRUE;
        '    else
        '    {
        '	IFF_writeError(chunkId, attributeName);
        '	return FALSE;
        '    }
        Try
            file.WriteLongwordSigned(value, IFF_Endianness)
            Return True
        Catch ex As Exception
            IFF_writeError(chunkId, attributeName)
            Return False
        End Try
        '}
    End Function

    'int IFF_readPaddingByte(FILE *file, const IFF_Long chunkSize, const IFF_ID chunkId)
    Public Function IFF_readPaddingByte(ByVal file As BinaryFile, ByVal chunkSize As Integer, _
                                        ByVal chunkId As String) As Boolean
        '{
        '    if(chunkSize % 2 != 0) /* Check whether the chunk size is an odd number */
        If chunkSize Mod 2 <> 0 Then ' Check whether the chunk size is an odd number
            '    {
            '        int byte = fgetc(file); /* Read padding byte */

            '        if(byte == EOF) /* We shouldn't have reached the EOF yet */
            '        {
            '    	    IFF_error("Unexpected end of file, while reading padding byte of '");
            '    	    IFF_errorId(chunkId);
            '    	    IFF_error("'\n");
            '	        return FALSE;
            '	     }

            '	     else if(byte != 0) /* Normally, a padding byte is 0, warn if this is not the case */
            '	        IFF_error("WARNING: Padding byte is non-zero!\n");
            Try
                Dim readByte As Byte = file.ReadByteUnsigned ' Read padding byte
                If readByte <> 0 Then ' Normally, a padding byte is 0, warn if this is not the case
                    IFF_error("WARNING: Padding byte is non-zero!" & vbCrLf)
                End If
            Catch ex As Exception ' We shouldn't have reached the EOF yet
                IFF_error("Unexpected end of file, while reading padding byte of '")
                IFF_errorId(chunkId)
                IFF_error("'" & vbCrLf)
                Return False
            End Try
            '    }
        End If

        '    return TRUE;
        Return True
        '}
    End Function

    'int IFF_writePaddingByte(FILE *file, const IFF_Long chunkSize, const IFF_ID chunkId)
    Public Function IFF_writePaddingByte(ByVal file As BinaryFile, ByVal chunkSize As Integer, _
                                         ByVal chunkId As String) As Boolean
        '{
        '    if(chunkSize % 2 != 0) /* Check whether the chunk size is an odd number */
        If chunkSize Mod 2 <> 0 Then
            '    {
            '	if(fputc('\0', file) == EOF)
            '	{
            '	    IFF_error("Cannot write padding byte of '");
            '	    IFF_errorId(chunkId);
            '	    IFF_error("'\n");
            '	    return FALSE;
            '	}
            '	else
            '	    return TRUE;
            '    }
            Try
                file.WriteByteUnsigned(0)
                Return True
            Catch ex As Exception
                IFF_error("Cannot write padding byte of '")
                IFF_errorId(chunkId)
                IFF_error("'" & vbCrLf)
                Return False
            End Try
        End If

        '    return TRUE;
        Return True
        '}
    End Function

End Module
