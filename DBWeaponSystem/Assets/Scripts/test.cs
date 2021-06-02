using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data.Sql;
using System.Data.SqlClient;
using System;
using System.Data;
using Assets.Scripts;

public class test : MonoBehaviour
{
    private string connectionString=
            "Data Source=127.0.0.1,1433;"+
            "Initial Catalog=DB5113xhj;"+
            "User Id=DB;"+
            "Password =123456;"+
            "Integrated Security=false;";
    private SqlConnection sqlCon;

    public void Start()
    {
        sqlCon = new SqlConnection(connectionString); //连接
        //ConnectSQL();
    }

    public void ConnectSQL()
    {

        sqlCon = new SqlConnection(connectionString); //连接

        try
        {
            sqlCon.Open();
            Debug.Log("链接成功！");
        }
        catch (Exception e)
        {
            Debug.Log("链接失败：" + e);
            throw;
        }
    }
    //适配器
    SqlDataAdapter sda = null;


    // Update is called once per frame
    void Update()
    {
        //按下空格键，执行对应操作
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space down");
            //SqlOperator.SQL("userlist","uname", "uno='20210111224737'","")
            //try
            //{
            //    //打开连接
            //    sqlCon.Open();
            //    //连接成功
            //    Debug.Log("Yes");
            //    //数据库操作语句
            //    string sql = "select * from userlist";
            //    //数据库操作
            //    sda = new SqlDataAdapter(sql, connectionString);
            //    //结果集
            //    DataSet ds = new DataSet();
            //    //将查询的结果放入结果集
            //    sda.Fill(ds, "userlist");
            //    //打印结果
            //    //print(ds.Tables[0].Rows[0][0]);
            //    foreach (DataTable dt in ds.Tables)
            //    {
            //        foreach (DataRow dr in dt.Rows)
            //            //print(dr);

            //        foreach (DataColumn dc in dr.Table.Columns)

            //            print(dc);
            //    }
            //    //print(ds);
            //    //writesql();
            //}

            ////如果出现异常，抛出
            //catch (System.Exception)
            //{
            //    Debug.Log("No");
            //    throw;
            //}

        }
        //空格键抬起，数据库连接关闭
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("space up");
            sqlCon.Close();
        }
    }

    public void writesql()
    {
        string sql = "insert into registry VALUES('zhan4','12345')"; //Player表名    (id,name,age)列名    (17,'大中',25)插入的值
        SqlCommand cmd = new SqlCommand(sql, sqlCon);
        try
        {
            cmd.ExecuteNonQuery();
            Debug.Log("写入成功！");
        }
        catch (Exception e)
        {
            Debug.Log("写入失败:" + e);
            throw;
        }
       sqlCon.Dispose();
    }

    public void ReadSQL(string tableName)
    {
        string str = "";
        //数据库操作语句
        string sql = "select * from "+tableName;
        //数据库操作
        SqlDataAdapter sda = new SqlDataAdapter(sql, connectionString);
        //结果集
        DataSet ds = new DataSet();
        //将查询的结果放入结果集
        sda.Fill(ds, "find");
        foreach (DataTable dt in ds.Tables)
        {
            foreach (DataRow dr in dt.Rows)

                foreach (DataColumn dc in dr.Table.Columns)

                    print(dr[dc]);
        }
        //按行和列打印出数据
        //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //{

        //    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
        //    {
        //        str += ds.Tables[0].Rows[i][j].ToString().Trim() + "    ";
        //        if (j == ds.Tables[0].Columns.Count - 1)
        //        {
        //            print(str);
        //            str = "";
        //        }
        //    }
        //}
    }

}
