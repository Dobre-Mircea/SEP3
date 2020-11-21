package com.example.model;

import com.example.tier3Mediator.Tier3Connection;
import com.example.tier3Mediator.Tier3SocketConnection;
import com.example.tier3NetworkPackages.NetworkPackage;
import org.springframework.stereotype.Component;


@Component
public class ModelManager implements Model, Tier1Model
{
    private Tier3Connection tier3Connection;

    public ModelManager()
    {
        tier3Connection = new Tier3SocketConnection();
        tier3Connection.connect(6969, "localhost");
        tier3Connection.waitFromTier3();
    }


    public NetworkPackage checkLogInInfo(String id, String password)
    {
        return tier3Connection.checkLogInData(id, password);
    }

    @Override
    public NetworkPackage assignGrade(String studentId, String course, int grade, String teacherID)
    {
        return tier3Connection.assignGrade(studentId, course, grade, teacherID);
    }

    @Override
    public NetworkPackage assignAbsence(String studentID, String course, String teacherID)
    {
        return tier3Connection.assignAbsence(studentID, course, teacherID);
    }


}
