Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub calcButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles calcButton.Click

        Dim tempWord As String = ""
        Dim match As Boolean = False

        Dim letterCount As Integer
        Dim wordCount As Integer = 0
        Dim uniqueWords(0) As String
        Dim uniqueWordsDecimal As Double
        Dim averageLength As Double

        For i = 0 To lyricTextBox.Text.Count - 1
            If Char.IsLetter(lyricTextBox.Text(i)) Or lyricTextBox.Text(i) = "-" Or lyricTextBox.Text(i) = "'" Then
                tempWord = tempWord + lyricTextBox.Text(i)
                letterCount += 1
            ElseIf lyricTextBox.Text(i) = " " Or lyricTextBox.Text(i) = vbCr Then
                If tempWord <> Nothing Then
                    wordCount = wordCount + 1
                End If
                match = False
                If tempWord <> Nothing Then
                    For findMatch As Integer = 0 To uniqueWords.Length - 1
                        If uniqueWords(findMatch) = tempWord.ToUpper Then
                            match = True
                        End If
                    Next
                End If
                If tempWord <> Nothing AndAlso match = False Then
                    If uniqueWords.Length = 0 Then
                        uniqueWords(0) = tempWord.ToUpper
                        Array.Resize(uniqueWords, uniqueWords.Length + 1)
                    Else
                        uniqueWords(uniqueWords.Length - 1) = tempWord.ToUpper
                        Array.Resize(uniqueWords, uniqueWords.Length + 1)
                    End If
                End If
                tempWord = Nothing
            End If
            If lyricTextBox.Text.Length = i + 1 AndAlso tempWord <> Nothing AndAlso match = False Then
                wordCount = wordCount + 1
                uniqueWords(uniqueWords.Length - 1) = tempWord.ToUpper
                Array.Resize(uniqueWords, uniqueWords.Length + 1)
            ElseIf lyricTextBox.Text.Length = i + 1 AndAlso tempWord <> Nothing Then
                wordCount = wordCount + 1
            End If
        Next i

        uniqueWordsListBox.Items.Clear()
        Array.Sort(uniqueWords)
        For List As Integer = 0 To uniqueWords.Length - 1
            If uniqueWords(List) <> Nothing Then
                If uniqueWords(List).Length > 1 Then
                    uniqueWordsListBox.Items.Add(uniqueWords(List).Remove(1) & uniqueWords(List).Remove(0, 1).ToLower)
                Else
                    uniqueWordsListBox.Items.Add(uniqueWords(List))
                End If
            End If
        Next List

        For Length As Integer = 0 To uniqueWords.Length - 1
            If uniqueWords(Length) <> Nothing Then
                averageLength = averageLength + uniqueWords(Length).Length
            End If
        Next Length
        uniqueWordsDecimal = uniqueWords.Count - 1

        totalWordsLabel.Text = wordCount
        uniqueWordsLabel.Text = uniqueWords.Length - 1
        percentUniqueLabel.Text = Format(uniqueWordsDecimal / wordCount, "P2")
        totalLettersLabel.Text = letterCount.ToString
        averageUniqueLengthLabel.Text = Format(averageLength / uniqueWordsDecimal, "N2")
        averageLengthLabel.Text = Format(letterCount / wordCount, "N2")

        showWordsButton.Enabled = True
        exportButton.Enabled = True

    End Sub

    Private Sub showWordsButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles showWordsButton.Click

        If Me.Size = New Size(575, 561) Then
            Me.MaximumSize = New Size(712, 561)
            Me.Size = New Size(712, 561)
            Me.MinimumSize = New Size(712, 561)
            showWordsButton.Text = "Hide Words"
        Else
            Me.MaximumSize = New Size(575, 561)
            Me.Size = New Size(575, 561)
            Me.MaximumSize = New Size(575, 561)
            showWordsButton.Text = "Show Words"
        End If

    End Sub

    Private Sub exportButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exportButton.Click

        Dim comparisonFile As IO.StreamWriter
        Dim author As String
        Dim title As String

        author = InputBox("Enter Author", "Author")
        title = InputBox("Enter Title", "Title")

        If IO.File.Exists("LyricStats.txt") Then
            comparisonFile = IO.File.AppendText("LyricStats.txt")
            comparisonFile.WriteLine(author & ", " & title)
            comparisonFile.WriteLine(totalWordsLabel.Text & ", " & uniqueWordsLabel.Text & ", " & percentUniqueLabel.Text)
            comparisonFile.WriteLine(totalLettersLabel.Text & ", " & averageUniqueLengthLabel.Text & ", " & averageLengthLabel.Text)
            comparisonFile.WriteLine("")
            comparisonFile.Close()
        Else
            System.IO.File.Create("LyricStats.txt").Dispose()
            comparisonFile = IO.File.AppendText("LyricStats.txt")
            comparisonFile.WriteLine("Author, Title")
            comparisonFile.WriteLine("Total Words, Unique Words, Percent Unique")
            comparisonFile.WriteLine("Total Letters, Average Unique Words Length, Average Word Length")
            comparisonFile.WriteLine("")
            comparisonFile.WriteLine(author & ", " & title)
            comparisonFile.WriteLine(totalWordsLabel.Text & ", " & uniqueWordsLabel.Text & ", " & percentUniqueLabel.Text)
            comparisonFile.WriteLine(totalLettersLabel.Text & ", " & averageUniqueLengthLabel.Text & ", " & averageLengthLabel.Text)
            comparisonFile.WriteLine("")
            comparisonFile.Close()
        End If

        exportButton.Enabled = False
    End Sub

    Private Sub lyricTextBox_Selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles lyricTextBox.Click, lyricTextBox.GotFocus

        lyricTextBox.SelectAll()

    End Sub

End Class
