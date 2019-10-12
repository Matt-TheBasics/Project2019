Option Strict On
Option Explicit On
Option Infer Off

Public Class Salaries
    Private _Doctor, _HeadNurse, _Nurses, _Maintenance, _Specialist, _Total As Integer

    Private Const NURSE_RATE As Integer = 400
    Private Const DOCTOR_RATE As Integer = 200
    Private Const MAINTENANCE_RATE As Integer = 200

    Public Sub New(ByVal DoctorHours As Integer, ByVal HeadNurseSalaray As Integer, ByVal NurseDays As Integer, ByVal TotalNurses As Integer,
                   ByVal MaintenanceDays As Integer, ByVal SpecialistRequired As Boolean, ByVal SpecialistDays As Integer)
        _Doctor = 1100 + (DOCTOR_RATE * DoctorHours)
        _Nurses = NurseDays * TotalNurses * NURSE_RATE
        _HeadNurse = HeadNurseSalaray
        _Maintenance = MaintenanceDays * MAINTENANCE_RATE

        If SpecialistRequired Then
            _Specialist = 2500 * SpecialistDays
        Else
            _Specialist = 0
        End If
    End Sub

    Public Function CalcTotal() As Integer
        _Total = _Doctor + _HeadNurse + _Nurses + _Maintenance + _Specialist
        Return _Total
    End Function
End Class
