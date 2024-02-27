Imports System.IO
Imports System.Xml

Public Class Form1
    Public fileCSVPath, fileXMLPath, fileJSONPath As String

    Private Sub AddColumnBTM_Click(sender As Object, e As EventArgs) Handles AddColumnBTM.Click
        Using formNombreColumna As New Form2()
            If formNombreColumna.ShowDialog() = DialogResult.OK Then
                Dim nombreNuevaColumna As String = formNombreColumna.NombreColumna

                If Not String.IsNullOrWhiteSpace(nombreNuevaColumna) Then
                    ListDataFileDGV.Columns.Add(nombreNuevaColumna, nombreNuevaColumna)
                End If
            End If
        End Using
    End Sub

    Private Sub AddRowBTM_Click(sender As Object, e As EventArgs) Handles AddRowBTM.Click
        ListDataFileDGV.Rows.Add()
    End Sub

    Private Sub DeleteColumnBTM_Click(sender As Object, e As EventArgs) Handles DeleteColumnBTM.Click
        If ListDataFileDGV.Columns.Count > 0 Then
            ListDataFileDGV.Columns.RemoveAt(ListDataFileDGV.Columns.Count - 1)
        End If
    End Sub

    Private Sub DeleteRowBTM_Click(sender As Object, e As EventArgs) Handles DeleteRowBTM.Click
        If ListDataFileDGV.SelectedRows.Count > 0 Then
            For Each filaSeleccionada As DataGridViewRow In ListDataFileDGV.SelectedRows
                If filaSeleccionada.IsNewRow Then
                    Return
                End If

                ListDataFileDGV.Rows.Remove(filaSeleccionada)
            Next

            Return
        End If

        MessageBox.Show("No has seleccionado una fila completa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub OpenDialog(ByRef filePath As String, ByVal filter As String)
        ListDataFileDGV.Rows.Clear()
        ListDataFileDGV.Columns.Clear()

        Dim fileDialog As New OpenFileDialog With
        {
            .Filter = filter
        }

        If fileDialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        filePath = fileDialog.FileName

        ActuallyFileLBL.Text = $"Archivo: {fileDialog.SafeFileName}"
    End Sub

    Public Function SaveDialog(ByRef filePath As String, ByVal filter As String) As Boolean
        If ListDataFileDGV.Rows.Count = 0 Then
            MessageBox.Show("No hay datos para guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If

        Dim saveFileTem As New SaveFileDialog With
        {
            .Filter = filter
        }

        If saveFileTem.ShowDialog() <> DialogResult.OK Then
            MessageBox.Show($"Datos no guardados desde el archivo {Path.GetFileName(saveFileTem.FileName)} incorrectamente.", "Operación cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return True
        End If

        filePath = saveFileTem.FileName

        ActuallyFileLBL.Text = $"Archivo: {Path.GetFileName(saveFileTem.FileName)}"

        Return False
    End Function

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenDialog(fileCSVPath, "Archivos CSV (*.csv)|*.csv")

        Using CSVReader As New StreamReader(fileCSVPath)
            Dim primeraLinea As String = CSVReader.ReadLine()

            If primeraLinea Is Nothing Then
                Return
            End If

            Dim encabezados As String() = primeraLinea.Split(","c)

            ListDataFileDGV.Columns.Clear()

            For Each encabezado As String In encabezados
                ListDataFileDGV.Columns.Add(encabezado, encabezado)
            Next

            While Not CSVReader.EndOfStream
                Dim line As String = CSVReader.ReadLine()
                Dim propertyless As String() = line.Split(","c)

                ListDataFileDGV.Rows.Add(propertyless)
            End While
        End Using

        MessageBox.Show("Datos cargados desde el archivo CSV correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If String.IsNullOrEmpty(fileCSVPath) Then
            If SaveDialog(fileCSVPath, "Archivos CSV (*.csv)|*.csv") Then
                Return
            End If

            SaveFileCSV()
        Else
            SaveFileCSV()
        End If
    End Sub

    Private Sub SaveHowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveHowToolStripMenuItem.Click
        If SaveDialog(fileCSVPath, "Archivos CSV (*.csv)|*.csv") Then
            Return
        End If

        SaveFileCSV()
    End Sub

    Public Sub SaveFileCSV()
        Using CSVwriter As New StreamWriter(fileCSVPath)
            For i As Integer = 0 To ListDataFileDGV.Columns.Count - 1
                CSVwriter.Write(ListDataFileDGV.Columns(i).HeaderText)

                If i < ListDataFileDGV.Columns.Count - 1 Then
                    CSVwriter.Write(",")
                End If
            Next

            CSVwriter.WriteLine()

            For i As Integer = 0 To ListDataFileDGV.Rows.Count - 1
                For j As Integer = 0 To ListDataFileDGV.Columns.Count - 1
                    CSVwriter.Write(ListDataFileDGV.Rows(i).Cells(j).Value)

                    If j < ListDataFileDGV.Columns.Count - 1 Then
                        CSVwriter.Write(",")
                    End If
                Next

                CSVwriter.WriteLine()
            Next
        End Using

        MessageBox.Show("Archivo CSV guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub OpenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem1.Click
        OpenDialog(fileXMLPath, "Archivos XML (*.xml)|*.xml")

        Dim dataSet As New DataSet()
        dataSet.ReadXml(fileXMLPath)

        If dataSet.Tables.Count > 0 Then
            Dim dataTable As DataTable = dataSet.Tables(0)

            For Each column As DataColumn In dataTable.Columns
                ListDataFileDGV.Columns.Add(column.ColumnName, column.ColumnName)
            Next

            For Each row As DataRow In dataTable.Rows
                ListDataFileDGV.Rows.Add(row.ItemArray)
            Next

            MessageBox.Show("Datos cargados desde el archivo XML correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("El archivo XML no contiene datos válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        If String.IsNullOrEmpty(fileXMLPath) Then
            If SaveDialog(fileXMLPath, "Archivos XML (*.xml)|*.xml") Then
                Return
            End If

            SaveFileXML()
        Else
            SaveFileXML()
        End If

    End Sub

    Private Sub SaveHowToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveHowToolStripMenuItem1.Click
        If SaveDialog(fileXMLPath, "Archivos XML (*.xml)|*.xml") Then
            Return
        End If

        SaveFileXML()
    End Sub
    Public Sub SaveFileXML()
        Dim xmlDoc As New XmlDocument()
        Dim xmlDeclaration As XmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
        xmlDoc.AppendChild(xmlDeclaration)

        Dim rootElement As XmlElement = xmlDoc.CreateElement("Datos")
        xmlDoc.AppendChild(rootElement)

        For i As Integer = 0 To ListDataFileDGV.Rows.Count - 1
            Dim rowElement As XmlElement = xmlDoc.CreateElement("Fila")

            For j As Integer = 0 To ListDataFileDGV.Columns.Count - 1
                Dim columnName As String = ListDataFileDGV.Columns(j).HeaderText
                Dim xmlElementName As String = GetValidXmlElementName(columnName)
                Dim cellValue As String = Convert.ToString(ListDataFileDGV.Rows(i).Cells(j).Value)

                Dim cellElement As XmlElement = xmlDoc.CreateElement(xmlElementName)
                cellElement.InnerText = cellValue

                rowElement.AppendChild(cellElement)
            Next

            rootElement.AppendChild(rowElement)
        Next

        xmlDoc.Save(fileXMLPath)

        MessageBox.Show("Datos guardados como archivo XML correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Function GetValidXmlElementName(ByVal input As String) As String
        Dim validName As String = input.Replace(" ", "_")

        validName = New String(validName.Where(Function(c) Char.IsLetterOrDigit(c) OrElse c = "_").ToArray())

        If Char.IsDigit(validName(0)) Then
            validName = "_" + validName
        End If

        Return validName
    End Function

    Private Sub OpenToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem2.Click
        OpenDialog(fileJSONPath, "Archivos JSON (*.json)|*.json")

        Dim jsonDatos As String = System.IO.File.ReadAllText(fileJSONPath)

        Dim listaObjetos = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, Object)))(jsonDatos)

        If listaObjetos IsNot Nothing AndAlso listaObjetos.Count > 0 Then
            For Each clave As String In listaObjetos(0).Keys
                ListDataFileDGV.Columns.Add(clave, clave)
            Next

            For Each objetoFila In listaObjetos
                Dim valores As Object() = objetoFila.Values.ToArray()
                ListDataFileDGV.Rows.Add(valores)
            Next

            MessageBox.Show("Datos cargados desde el archivo JSON correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("El archivo JSON no contiene datos válidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem2.Click
        If String.IsNullOrEmpty(fileJSONPath) Then
            If SaveDialog(fileJSONPath, "Archivos JSON (*.json)|*.json") Then
                Return
            End If

            SaveFileJSON()
        Else
            SaveFileJSON()
        End If
    End Sub

    Private Sub SaveHowToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SaveHowToolStripMenuItem2.Click
        If SaveDialog(fileJSONPath, "Archivos JSON (*.json)|*.json") Then
            Return
        End If

        SaveFileJSON()
    End Sub

    Public Sub SaveFileJSON()
        Dim listaObjetos As New List(Of Object)()

        For Each fila As DataGridViewRow In ListDataFileDGV.Rows
            If Not fila.IsNewRow Then
                Dim objetoFila As New Dictionary(Of String, Object)()

                For Each celda As DataGridViewCell In fila.Cells
                    Dim nombreColumna As String = ListDataFileDGV.Columns(celda.ColumnIndex).HeaderText
                    objetoFila(nombreColumna) = celda.Value
                Next

                listaObjetos.Add(objetoFila)
            End If
        Next

        Dim jsonDatos As String = Newtonsoft.Json.JsonConvert.SerializeObject(listaObjetos, Newtonsoft.Json.Formatting.Indented)

        System.IO.File.WriteAllText(fileJSONPath, jsonDatos)

        MessageBox.Show("Datos guardados como archivo JSON correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
