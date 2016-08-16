Imports libvbilbm.ifftypes
Imports System.Text.Encoding

Public Module id

    '=============
    ' libiff/id.h
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

    '#ifndef __IFF_ID_H
    '#define __IFF_ID_H

    '#include <stdio.h>
    '#include "ifftypes.h"

    '#ifdef __cplusplus
    'extern "C" {
    '#endif

    '/**
    ' * Creates a 4 character ID from a string.
    ' *
    ' * @param id A 4 character IFF id
    ' * @param idString String containing a 4 character ID
    ' */
    'void IFF_createId(IFF_ID id, const char *idString);

    '/**
    ' * Compares two IFF ids
    ' *
    ' * @param id1 An IFF ID to compare
    ' * @param id2 An IFF ID to compare
    ' * @return 0 if the IDs are equal, a value lower than 0 if id1 is lower than id2, a value higher than 1 if id1 is higher than id2
    ' */
    'int IFF_compareId(const IFF_ID id1, const char* id2);

    '/**
    ' * Reads an IFF id from a file
    ' *
    ' * @param file File descriptor of the file
    ' * @param id A 4 character IFF id
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @param attributeName The name of the attribute that is examined (used for error reporting)
    ' * @return TRUE if the ID is succesfully read, else FALSE
    ' */
    'int IFF_readId(FILE *file, IFF_ID id, const IFF_ID chunkId, const char *attributeName);

    '/**
    ' * Writes an IFF id to a file
    ' *
    ' * @param file File descriptor of the file
    ' * @param id A 4 character IFF id
    ' * @param chunkId A 4 character chunk id in which the operation takes place (used for error reporting)
    ' * @param attributeName The name of the attribute that is examined (used for error reporting)
    ' * @return TRUE if the ID is succesfully written, else FALSE
    ' */
    'int IFF_writeId(FILE *file, const IFF_ID id, const IFF_ID chunkId, const char *attributeName);

    '/**
    ' * Checks whether an IFF id is valid
    ' *
    ' * @param id A 4 character IFF id
    ' * @return TRUE if the IFF id is valid, else FALSE
    ' */
    'int IFF_checkId(const IFF_ID id);

    '/**
    ' * Prints an IFF id
    ' *
    ' * @param id A 4 character IFF id
    ' */
    'void IFF_printId(const IFF_ID id);

    '#ifdef __cplusplus
    '}
    '#endif

    '#endif

    '=============
    ' libiff/id.c
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
    '#include "id.h"
    '#include <string.h>
    '#include "error.h"

    'void IFF_createId(IFF_ID id, const char *idString)
    Public Sub IFF_createId(ByRef id As String, ByVal idString As String)
        '{
        '    strncpy_s(id, IFF_ID_SIZE, idString, IFF_ID_SIZE);
        id = Left(idString, IFF_ID_SIZE)
        '}
    End Sub

    'int IFF_compareId(const IFF_ID id1, const char* id2)
    Public Function IFF_compareId(ByVal id1 As String, ByVal id2 As String) As Integer
        '{
        '    return strncmp(id1, id2, IFF_ID_SIZE);
        If id1 < id2 Then
            Return -1
        ElseIf id1 = id2 Then
            Return 0
        Else 'If id1 > id2 Then
            Return 1
        End If
        '}
    End Function

    'int IFF_readId(FILE *file, IFF_ID id, const IFF_ID chunkId, const char *attributeName)
    Public Function IFF_readId(ByVal file As BinaryFile, ByRef id As String, _
                               ByVal chunkId As String, ByVal attributeName As String) As Boolean
        '{
        Dim bytes(IFF_ID_SIZE - 1) As Byte
        '    if(fread(id, IFF_ID_SIZE, 1, file) == 1)
        If file.Read(bytes, 0, IFF_ID_SIZE) = IFF_ID_SIZE Then
            id = ASCII.GetString(bytes)
            '	return TRUE;
            Return True
            '    else
        Else
            '    {
            '	IFF_readError(chunkId, attributeName);
            IFF_readError(chunkId, attributeName)
            id = ASCII.GetString(bytes)
            '	return FALSE;
            Return False
            '    }
        End If
        '}
    End Function

    'int IFF_writeId(FILE *file, const IFF_ID id, const IFF_ID chunkId, const char *attributeName)
    Public Function IFF_writeId(ByVal file As BinaryFile, ByVal id As String, _
                                ByVal chunkId As String, ByVal attributeName As String) As Boolean
        '{
        Dim bytes(IFF_ID_SIZE - 1) As Byte
        bytes = ASCII.GetBytes(id)
        '    if(fwrite(id, IFF_ID_SIZE, 1, file) == 1)
        Try
            file.Write(bytes, 0, IFF_ID_SIZE)
            '	return TRUE;
            Return True
            '    else
        Catch
            '    {
            '	IFF_writeError(chunkId, attributeName);
            IFF_writeError(chunkId, attributeName)
            '	return FALSE;
            Return False
            '    }
        End Try
        '}
    End Function

    'int IFF_checkId(const IFF_ID id)
    Public Function IFF_checkId(ByVal id As String)
        '{
        '    unsigned int i;

        ' VB specific check: does the id have 4 characters?
        If id.Length > IFF_ID_SIZE Then
            IFF_error("ID '{0}' is longer than IFF ID size!", id)
        End If

        '    /* ID characters must be between 0x20 and 0x7e */

        Dim bytes(IFF_ID_SIZE - 1) As Byte
        bytes = ASCII.GetBytes(id)

        '    for(i = 0; i < IFF_ID_SIZE; i++)
        For i As Integer = 0 To IFF_ID_SIZE - 1
            '    {
            '	if(id[i] < 0x20 || id[i] > 0x7e)
            If bytes(i) < &H20 OrElse bytes(i) > &H7E Then
                '	{
                '	    IFF_error("Illegal character: '%c' in ID!\n", id[i]);
                IFF_error("Illegal character: '{0}' in ID!" & vbCrLf, id(i))
                '	    return FALSE;
                Return False
                '	}
            End If
            '    }
        Next

        '    /* Spaces may not precede an ID, trailing spaces are ok */

        '    if(id[0] == ' ')
        If bytes(0) = Asc(" ") Then
            '    {
            '	IFF_error("Spaces may not precede an ID!\n");
            IFF_error("Spaces may not precede an ID!" & vbCrLf)
            '	return FALSE;
            Return False
            '    }
        End If

        '    return TRUE;
        Return True
        '}
    End Function

    'void IFF_printId(const IFF_ID id)
    Public Sub IFF_printId(ByVal id As String)
        '{
        '    unsigned int i;

        '    for(i = 0; i < IFF_ID_SIZE; i++)
        For i As Integer = 1 To IFF_ID_SIZE
            '	printf("%c", id[i]);
            Console.Write(id(i))
        Next
        '}
    End Sub

End Module
