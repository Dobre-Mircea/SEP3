package com.example.tier3Mediator;

import com.example.tier3NetworkPackages.NetworkPackage;

public interface Tier3Connection
{
    public NetworkPackage checkLogInData(String id, String password);

    public NetworkPackage assignGrade(String studentId, String course, int grade, String teacherID);
    public NetworkPackage assignAbsence(String studentId, String course, String teacherID);
    public NetworkPackage motivateAbsence(String studentID, String course, String date, String teacherID);


    public boolean isConnected();
    public void closeSocket();
    public void connect(int port, String host);
    public void waitFromTier3();

    public NetworkPackage createTeacher(String firstName, String lastName, String password);

    public NetworkPackage editTeacher(String id, String password);

    public NetworkPackage deleteTeacher(String id);

    public NetworkPackage createStudent(String firstName, String lastName, String address, String password, String phoneNr, String birthday);

    public NetworkPackage deleteStudent(String id);

    public NetworkPackage editStudent(String studentId, String address, String password, String phoneNr);

    public NetworkPackage createClass(String classNr, String classLetter, String teacherId);
}
