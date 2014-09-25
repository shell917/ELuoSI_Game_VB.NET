Public Class Form1
    Dim beijing(24, 9) As Integer    '全部区域初始化为全0，0代表无方块，1代表有方块
    Dim btnDown(3) As Button      '用4个button按钮来代表下落方块
    Dim col(3) As Integer           '列
    Dim row(3) As Integer         '行
    Dim score As Integer = 0                 '分数
    Dim tempScore As Integer = 0             '用来判断等级的临时分数
    Dim grade As Integer = 0                '等级
    Dim k As Integer = 0         '定义k为btnDown下标，来引用btnDown,(0,1,2,3)
    Dim a1(,) As Integer = {{0, 0, 0, 0}, {0, 1, 1, 0}, {0, 1, 1, 0}, {0, 0, 0, 0}}
    Dim b1(,) As Integer = {{1, 1, 1, 1}, {0, 0, 0, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}}
    Dim b2(,) As Integer = {{1, 0, 0, 0}, {1, 0, 0, 0}, {1, 0, 0, 0}, {1, 0, 0, 0}}
    Dim c1(,) As Integer = {{0, 0, 0, 0}, {1, 0, 0, 0}, {1, 0, 0, 0}, {1, 1, 0, 0}}
    Dim c2(,) As Integer = {{0, 0, 0, 0}, {1, 1, 1, 0}, {1, 0, 0, 0}, {0, 0, 0, 0}}
    Dim c3(,) As Integer = {{1, 1, 0, 0}, {0, 1, 0, 0}, {0, 1, 0, 0}, {0, 0, 0, 0}}
    Dim c4(,) As Integer = {{0, 0, 1, 0}, {1, 1, 1, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}}
    Dim d1(,) As Integer = {{0, 1, 0, 0}, {0, 1, 0, 0}, {1, 1, 0, 0}, {0, 0, 0, 0}}
    Dim d2(,) As Integer = {{1, 0, 0, 0}, {1, 1, 1, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}}
    Dim d3(,) As Integer = {{0, 1, 1, 0}, {0, 1, 0, 0}, {0, 1, 0, 0}, {0, 0, 0, 0}}
    Dim d4(,) As Integer = {{0, 0, 0, 0}, {1, 1, 1, 0}, {0, 0, 1, 0}, {0, 0, 0, 0}}
    Dim e1(,) As Integer = {{0, 1, 0, 0}, {1, 1, 1, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}}
    Dim e2(,) As Integer = {{0, 1, 0, 0}, {0, 1, 1, 0}, {0, 1, 0, 0}, {0, 0, 0, 0}}
    Dim e3(,) As Integer = {{0, 0, 0, 0}, {1, 1, 1, 0}, {0, 1, 0, 0}, {0, 0, 0, 0}}
    Dim e4(,) As Integer = {{0, 1, 0, 0}, {1, 1, 0, 0}, {0, 1, 0, 0}, {0, 0, 0, 0}}
    Dim f1(,) As Integer = {{1, 1, 0, 0}, {0, 1, 1, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}}
    Dim f2(,) As Integer = {{0, 0, 1, 0}, {0, 1, 1, 0}, {0, 1, 0, 0}, {0, 0, 0, 0}}
    Dim g1(,) As Integer = {{0, 1, 1, 0}, {1, 1, 0, 0}, {0, 0, 0, 0}, {0, 0, 0, 0}}
    Dim g2(,) As Integer = {{0, 1, 0, 0}, {0, 1, 1, 0}, {0, 0, 1, 0}, {0, 0, 0, 0}}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.TabStop = False
        TextBox2.TabStop = False
        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
    End Sub
    Public Sub construct()
        Dim random As Integer
        Randomize()        '初始化随机数产生器
        random = Int(7 * Rnd() + 1)     '[1~7]随机数用来表示对应的七类砖块
        Select Case random
            Case 1
                newButton(a1, random)
            Case 2
                Dim subRandom As Integer
                Randomize()
                subRandom = Int(2 * Rnd() + 1)
                Select Case subRandom
                    Case 1
                        newButton(b1, random)
                    Case 2
                        newButton(b2, random)
                End Select
            Case 3
                Dim subRandom As Integer
                Randomize()
                subRandom = Int(4 * Rnd() + 1)
                Select Case subRandom
                    Case 1
                        newButton(c1, random)
                    Case 2
                        newButton(c2, random)
                    Case 3
                        newButton(c3, random)
                    Case 4
                        newButton(c4, random)
                End Select
            Case 4
                Dim subRandom As Integer
                Randomize()
                subRandom = Int(4 * Rnd() + 1)
                Select Case subRandom
                    Case 1
                        newButton(d1, random)
                    Case 2
                        newButton(d2, random)
                    Case 3
                        newButton(d3, random)
                    Case 4
                        newButton(d4, random)
                End Select
            Case 5
                Dim subRandom As Integer
                Randomize()
                subRandom = Int(4 * Rnd() + 1)
                Select Case subRandom
                    Case 1
                        newButton(e1, random)
                    Case 2
                        newButton(e2, random)
                    Case 3
                        newButton(e3, random)
                    Case 4
                        newButton(e4, random)
                End Select
            Case 6
                Dim subRandom As Integer
                Randomize()
                subRandom = Int(2 * Rnd() + 1)
                Select Case subRandom
                    Case 1
                        newButton(f1, random)
                    Case 2
                        newButton(f2, random)
                End Select
            Case 7
                Dim subRandom As Integer
                Randomize()
                subRandom = Int(2 * Rnd() + 1)
                Select Case subRandom
                    Case 1
                        newButton(g1, random)
                    Case 2
                        newButton(g2, random)
                End Select
        End Select
    End Sub
    Public Function newButton(ByVal array(,) As Integer, ByVal Random As Integer)          '产生一个新的方块形状
        k = 0           '为下一个方块初始化
        ' btnDown(k) = New Button
        For i = 0 To 3
            For j = 0 To 3
                If array(i, j) = 1 Then
                    btnDown(k) = New Button
                    '定义各button的属性值
                    btnDown(k).Height = 15
                    btnDown(k).Width = 15
                    btnDown(k).Top = 40 + 15 * i
                    btnDown(k).Left = (3 + j) * 15
                    btnDown(k).BackColor = Color.Red
                    btnDown(k).Enabled = False
                    'Me.Label2.Controls.Add(btnDown(k))
                    Me.Label1.Controls.Add(btnDown(k))
                    k += 1
                End If
            Next
        Next
    End Function

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        downMethod(sender, e)
    End Sub

    Public Sub downMethod(ByVal sender As System.Object, ByVal e As System.EventArgs)     '砖块下落时调用的函数
        For i = 0 To 9              '判断游戏是否结束
            If beijing(22, i) = 1 Then
                Timer1.Enabled = False
                MessageBox.Show("game over!")
                End
            End If
        Next
        If Label1.Bottom - btnDown(0).Bottom >= 15 And Label1.Bottom - btnDown(1).Bottom >= 15 And Label1.Bottom - btnDown(2).Bottom >= 15 And Label1.Bottom - btnDown(3).Bottom >= 15 Then
            For i = 0 To 3
                col(i) = Int((btnDown(i).Left - Label1.Left) / 15)
            Next
            For i = 0 To 3
                row(i) = Int((Label1.Bottom - btnDown(i).Bottom) / 15)
            Next
            If beijing(row(0) - 1, col(0)) + beijing(row(1) - 1, col(1)) + beijing(row(2) - 1, col(2)) + beijing(row(3) - 1, col(3)) = 0 Then
                btnDown(0).Top += 15
                btnDown(1).Top += 15
                btnDown(2).Top += 15
                btnDown(3).Top += 15
            Else
                beijing(row(0), col(0)) = 1               '将背景区域相应位置的元素值置1
                beijing(row(1), col(1)) = 1
                beijing(row(2), col(2)) = 1
                beijing(row(3), col(3)) = 1
                For i = 0 To 3                '定义砖块名称，为消行做准备
                    btnDown(i).Name = row(i).ToString + col(i).ToString
                Next
                delete()              '消行函数
                construct()        '产生下一个砖块   
            End If
        ElseIf row(0) = 0 Or row(1) = 0 Or row(2) = 0 Or row(3) = 0 Then
            beijing(row(0), col(0)) = 1               '将背景区域相应位置的元素值置1
            beijing(row(1), col(1)) = 1
            beijing(row(2), col(2)) = 1
            beijing(row(3), col(3)) = 1
            For i = 0 To 3                '定义砖块名称，为消行做准备
                btnDown(i).Name = row(i).ToString + col(i).ToString
            Next
            delete()              '消行函数
            construct()       '产生下一个砖块   
        Else
            beijing(row(0) - 1, col(0)) = 1               '将背景区域相应位置的元素值置1
            beijing(row(1) - 1, col(1)) = 1
            beijing(row(2) - 1, col(2)) = 1
            beijing(row(3) - 1, col(3)) = 1
            For i = 0 To 3                      '定义砖块名称，为消行做准备
                btnDown(i).Name = (row(i) - 1).ToString + col(i).ToString
            Next
            delete()            '消行函数
            construct() '产生下一个砖块            
        End If
    End Sub
    Private Sub Form1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "n" Then        '开始新游戏
            construct()
            Timer1.Enabled = True
        End If
        If e.KeyChar = "w" Then                      '旋转
            xuanzhuan()
        End If
        If e.KeyChar = "a" And btnDown(0).Left > Label1.Left And btnDown(1).Left > Label1.Left And btnDown(2).Left > Label1.Left And btnDown(3).Left > Label1.Left Then                        '往左
            For i = 0 To 3
                col(i) = Int((btnDown(i).Left - Label1.Left) / 15)
            Next
            For i = 0 To 3
                row(i) = Int((Label1.Bottom - btnDown(i).Bottom) / 15)
            Next
            If beijing(row(0), col(0) - 1) + beijing(row(1), col(1) - 1) + beijing(row(2), col(2) - 1) + beijing(row(3), col(3) - 1) = 0 Then
                btnDown(0).Left -= 15
                btnDown(1).Left -= 15
                btnDown(2).Left -= 15
                btnDown(3).Left -= 15
            End If
        End If
        If e.KeyChar = "s" Then                        '往下
            downMethod(sender, e)
        End If
        If e.KeyChar = "d" And btnDown(0).Right < Label1.Right And btnDown(1).Right < Label1.Right And btnDown(2).Right < Label1.Right And btnDown(3).Right < Label1.Right Then                        '往右
            For i = 0 To 3
                col(i) = Int((btnDown(i).Left - Label1.Left) / 15)
            Next
            For i = 0 To 3
                row(i) = Int((Label1.Bottom - btnDown(i).Bottom) / 15)
            Next

            If beijing(row(0), col(0) + 1) + beijing(row(1), col(1) + 1) + beijing(row(2), col(2) + 1) + beijing(row(3), col(3) + 1) = 0 Then
                btnDown(0).Left += 15
                btnDown(1).Left += 15
                btnDown(2).Left += 15
                btnDown(3).Left += 15
            End If
        End If

        If e.KeyChar = "p" Then        '暂停
            Timer1.Stop()
        End If
        If e.KeyChar = "k" Then        '开始
            Timer1.Start()
        End If
        If e.KeyChar = "r" Then        '重新开始
            Dim temp As Integer = 0
            While (temp < 10)
                temp += 1
                For Each c As Control In Label1.Controls
                    If c.GetType().ToString() = "System.Windows.Forms.Button" Then
                        Label1.Controls.Remove(c)
                    End If
                Next
            End While
            For i = 0 To 23
                For j = 0 To 9
                    beijing(i, j) = 0
                Next
            Next
            construct()
            Timer1.Enabled = True
        End If
        If e.KeyChar = "e" Then           '退出游戏
            End
        End If
    End Sub
    Public Sub xuanzhuan()                         '旋转函数
        Dim newCol(9) As Integer
        Dim newRow(24) As Integer
        For i = 0 To 3
            col(i) = Int((btnDown(i).Left - Label1.Left) / 15)
        Next
        For i = 0 To 3
            row(i) = Int((label1.Bottom - btnDown(i).Bottom) / 15)
        Next
        For i = 0 To 3
            newRow(i) = (row(1) + (col(i) - col(1)))
            newCol(i) = (col(1) - (row(i) - row(1)))
        Next
        For i = 0 To 3
            row(i) = newRow(i)
            col(i) = newCol(i)
        Next
        If newCol(0) * 15 >= label1.Left And newCol(1) * 15 >= label1.Left And newCol(2) * 15 >= label1.Left And newCol(3) * 15 >= label1.Left Then
            If newCol(0) * 15 + 15 < label1.Right And newCol(1) * 15 + 15 < label1.Right And newCol(2) * 15 + 15 < label1.Right And newCol(3) * 15 + 15 < label1.Right Then
                If beijing(newRow(0), newCol(0)) + beijing(newRow(1), newCol(1)) + beijing(newRow(2), newCol(2)) + beijing(newRow(3), newCol(3)) = 0 Then
                    If beijing(newRow(0), newCol(0)) + beijing(newRow(1), newCol(1)) + beijing(newRow(2), newCol(2)) + beijing(newRow(3), newCol(3)) = 0 Then
                        For i = 0 To 3
                            btnDown(i).Left = 15 * newCol(i) + label1.Left
                            btnDown(i).Top = label1.Bottom - newRow(i) * 15 - 15
                        Next
                    End If
                End If
            End If
        End If
    End Sub
    Public Sub delete()                       '消行函数
        If tempScore >= 800 Then               '等级提升
            grade += 1
            TextBox2.Text = grade
            Timer1.Interval -= 50
            tempScore = 0
        End If
        For i = 0 To 24
            Dim sum As Integer = 0
            For j = 0 To 9
                sum += beijing(i, j)
            Next
            If sum = 10 Then
                score += 100
                tempScore += 100
                TextBox1.Text = score
                For j = 0 To 9
                    Label1.Controls.RemoveByKey(i.ToString + j.ToString)                '删除所消行方块
                    beijing(i, j) = 0
                Next
                For flag = 1 To 24
                    For flag2 = 0 To 9
                        For Each c As Control In Label1.Controls
                            If c.Name = (i + flag).ToString + flag2.ToString Then
                                c.Top += 15
                                beijing(i + flag, flag2) = 0     '将方块下落前的位置置0
                                beijing(i + flag - 1, flag2) = 1        '将方块下落后的位置置1，表明该位置有方块
                                c.Name = (i + flag - 1).ToString + flag2.ToString               '方块下落后修改方块的名称
                                Exit For
                            End If
                        Next
                    Next
                Next
                i -= 1              '如果有需要消行，当执行完前面步骤后，将i-1，从而可以再次判断所消行位置背景元素值
            End If
        Next
    End Sub
    Private Sub 开始新游戏ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 开始新游戏ToolStripMenuItem.Click
        construct()
        Timer1.Enabled = True
    End Sub

    Private Sub 开始ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 开始ToolStripMenuItem.Click
        Timer1.Start()
    End Sub

    Private Sub 暂停ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 暂停ToolStripMenuItem.Click
        Timer1.Stop()
    End Sub

    Private Sub 重新开始ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 重新开始ToolStripMenuItem.Click
        Dim temp As Integer = 0
        While (temp < 10)
            temp += 1
            For Each c As Control In Label1.Controls
                If c.GetType().ToString() = "System.Windows.Forms.Button" Then
                    Label1.Controls.Remove(c)
                End If
            Next
        End While
        For i = 0 To 23
            For j = 0 To 9
                beijing(i, j) = 0
            Next
        Next
        construct()
        Timer1.Enabled = True
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub
End Class
