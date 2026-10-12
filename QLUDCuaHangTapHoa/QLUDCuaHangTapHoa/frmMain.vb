Public Class frmMain

    Dim dsForm As List(Of Form)

    Private Sub frmMain_load(sender As Object, e As EventArgs) Handles MyBase.Load
        dsForm = New List(Of Form)()
    End Sub

    Function Timform(type As Type)
        For Each frm In dsForm
            If frm.GetType() Is type Then
                If frm.IsDisposed = True Then
                    dsForm.Remove(frm)
                    frm = Nothing
                End If
                Return frm
            End If
        Next
        Return Nothing
    End Function

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Dim frm = Timform(frmSanPham.GetType())
        If frm IsNot Nothing Then
            frm.show()
            Return
        End If

        Dim frm1 As frmSanPham = New frmSanPham()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim frm = Timform(frmLoaiSanPham.GetType())
        If frm IsNot Nothing Then
            frm.show()
            Return
        End If

        Dim frm1 As frmLoaiSanPham = New frmLoaiSanPham()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub NhanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhanToolStripMenuItem.Click
        Dim frm = Timform(frmNhanVien.GetType())
        If frm IsNot Nothing Then
            frm.show()
            Return
        End If

        Dim frm1 As frmNhanVien = New frmNhanVien()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub KhachHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhachHangToolStripMenuItem.Click
        Dim frm = Timform(frmKhachHang.GetType())
        If frm IsNot Nothing Then
            frm.show()
            Return
        End If

        Dim frm1 As frmKhachHang = New frmKhachHang()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub TaiKhoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaiKhoanToolStripMenuItem.Click
        Dim frm = Timform(frmTaiKhoan.GetType())
        If frm IsNot Nothing Then
            frm.show()
            Return
        End If

        Dim frm1 As frmTaiKhoan = New frmTaiKhoan()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub NhaCungCapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhaCungCapToolStripMenuItem.Click
        Dim frm = Timform(frmNhaCungCap.GetType())
        If frm IsNot Nothing Then
            frm.show()
            Return
        End If

        Dim frm1 As frmNhaCungCap = New frmNhaCungCap()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub KhuVucToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KhuVucToolStripMenuItem.Click
        Dim frm = Timform(frmKhuVuc.GetType())
        If frm IsNot Nothing Then
            frm.show()
            Return
        End If

        Dim frm1 As frmKhuVuc = New frmKhuVuc()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub DanhSachDonHangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSachDonHangToolStripMenuItem.Click
        Dim frm = Timform(frmDanhSachPhieuBanHang.GetType())
        If frm IsNot Nothing Then
            frm.show()
            Return
        End If

        Dim frm1 As frmDanhSachPhieuBanHang = New frmDanhSachPhieuBanHang()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub DanhSachPhieuChiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSachPhieuChiToolStripMenuItem.Click
        Dim frm = Timform(frmPhieuChi.GetType())
        If frm IsNot Nothing Then
            frm.show()
            Return
        End If

        Dim frm1 As frmPhieuChi = New frmPhieuChi()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub

    Private Sub DanhSachPhieuNhapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DanhSachPhieuNhapToolStripMenuItem.Click
        Dim frm = Timform(frmPhieuNhapHang.GetType())
        If frm IsNot Nothing Then
            frm.show()
            Return
        End If

        Dim frm1 As frmPhieuNhapHang = New frmPhieuNhapHang()
        frm1.MdiParent = Me
        frm1.WindowState = FormWindowState.Maximized
        frm1.Show()
        dsForm.Add(frm1)
    End Sub
End Class
