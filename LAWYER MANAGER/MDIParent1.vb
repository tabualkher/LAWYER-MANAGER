Imports System.ComponentModel
Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles TScustomer.Click
        ' Create a new instance of the child form.
        Dim frmcustomers As New FrmCustomers
        ' Make it a child of this MDI form before showing it.
        frmcustomers.MdiParent = Me
        frmcustomers.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles TSemployee.Click
        Dim frmemployee As New FrmEmployee
        frmemployee.MdiParent = Me
        frmemployee.Show()


        'Dim ChildForm As New System.Windows.Forms.Form
        '' Make it a child of this MDI form before showing it.
        'ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Window " & m_ChildFormNumber

        'ChildForm.Show()
        'Dim OpenFileDialog As New OpenFileDialog
        'OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        'If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
        '    Dim FileName As String = OpenFileDialog.FileName
        '    ' TODO: Add code here to open the file.
        'End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MDIParent1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles TSpermession.Click

    End Sub

    Private Sub TSexit_Click(sender As Object, e As EventArgs) Handles TSexit.Click
        Dim a As String = MsgBox("هل ترغب فى انهاء البرنامج", vbYesNo)
        If a = vbYes Then
            End
        Else
            Exit Sub
        End If

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Tcourt_Click(sender As Object, e As EventArgs) Handles Tcourt.Click
        Dim frmcases As New FrmCases
        frmcases.MdiParent = Me
        frmcases.Show()
    End Sub

    Private Sub TSsession_Click(sender As Object, e As EventArgs) Handles TSsession.Click
        Dim frmsessionreg As New FrmSessionReg
        frmsessionreg.MdiParent = Me
        frmsessionreg.Show()
    End Sub
End Class
