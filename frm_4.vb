Imports System.Data.SqlClient

Public Class frm_4
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim FirstName As String = txtFirstName.Text
        Dim LastName As String = txtLastName.Text
        Dim Email As String = txtEmail.Text
        Dim Password As String = txtPassword.Text
        Dim Username As String = txtUsername.Text
        Dim ContactNumber As String = txtContactNumber.Text

        Dim query As String = "insert into regis_tab values (@firstname,@lastname,@email,@password,@username,@contactnumber)"
        Using con As SqlConnection = New SqlConnection("Data Source=LAPTOP-IJCIEVT5\MSSQLSERVER01;Initial Catalog=regisdb;Integrated Security=True")

            Using cnn As SqlCommand = New SqlCommand(query, con)

                cnn.Parameters.AddWithValue("@FirstName", FirstName)
                cnn.Parameters.AddWithValue("@LastName", LastName)
                cnn.Parameters.AddWithValue("@Email", Email)
                cnn.Parameters.AddWithValue("@Password", Password)
                cnn.Parameters.AddWithValue("@Username", Username)
                cnn.Parameters.AddWithValue("@ContactNumber", ContactNumber)

                con.Open()
                cnn.ExecuteNonQuery()
                con.Close()

                MessageBox.Show("registration completed")




            End Using
        End Using

    End Sub


End Class
