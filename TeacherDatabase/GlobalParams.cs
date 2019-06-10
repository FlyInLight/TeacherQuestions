﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherDatabase
{
    //全局参数
    public class GlobalParams
    {
        public static string myAccount = "";
        public static string subjectName = "";
        public static string condition = "true";
        public static int startIndex = 0;
        public static int indexNumbers = 30;
        public static int page = 1;
        public static int thisPage = 1;
        //是否刷新
        public static bool dataRefresh = false;
        //试题类型刷新
        public static bool typeRefresh = false;
        //查看共享试题sql语句
        public static string sqlShowShare = " UNION SELECT * FROM question WHERE share=0 and " + GlobalParams.Condition;

        public static string SqlShowShare
        {
            get { return sqlShowShare; }
            set { sqlShowShare = value; }
        }

        public static bool TypeRefresh
        {
            get { return typeRefresh; }
            set { typeRefresh = value; }
        }
        //public static string sqlStr = "select * from question where " + condition + " limit " + startIndex + "," + indexNumbers;

        //public  string sqlStr = "select * from question where " + condition + " limit " + startIndex + "," + indexNumbers;
        //public GlobalParams()
        //{
        //    condition = "true";
        //    startIndex = "0";
        //    indexNumbers = "30";
        //    //sqlStr = "select * from question where " + condition + " limit " + startIndex + "," + indexNumbers;
        //}
        public static string Condition
        {
            get { return condition; }
            set { condition = value; }
        }
        public static int StartIndex
        {
            get { return startIndex; }
            set { startIndex = value; }
        }
        public static int IndexNumbers
        {
            get { return indexNumbers; }
            set { indexNumbers = value; }
        }
        public static int Page
        {
            get { return page; }
            set { page = value; }
        }
        public static int ThisPage
        {
            get { return thisPage; }
            set { thisPage = value; }
        }

        public static string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }
        public static string MyAccount
        {
            get { return myAccount; }
            set { myAccount = value; }
        }

        
        public static bool DataRefresh
        {
            get { return dataRefresh; }
            set { dataRefresh = value; }
        }

    }
}
