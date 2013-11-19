using System.Data;
using DataBaseOperate2;

namespace BLL
{
    public class DataPrintDAL
    {
        //SqlExcuClass objExcuClass = new SqlExcuClass();
        DataBaseOperateClass2 objDataBaseOperateClass2 = new DataBaseOperateClass2();


        string SqlString;

        public DataTable SchollInfo()
        {
            SqlString = "Select * from V_SchoolInfo";
            return objDataBaseOperateClass2.ShowTable(SqlString);
        }



        public DataTable PrintStuInfo()
        {
            SqlString = "select StuNum AS ѧ��,StuName AS ѧ������,StuSex AS �Ա�,Policity AS ������Ŀ,Favor AS ����,StuScore AS �ܷ�,Meno AS ����,Class.ClaName AS �༶,Department.DeptName AS ϵ��,Phone AS ��ϵ�绰,Address AS ��ϵ��ַ from dbo.Student join Class on Student.ClaNum=Class.ClaNum join Department on Class.DeptNum=Department.DeptNum";
            return (objDataBaseOperateClass2.ShowTable(SqlString));
        }

        public DataTable PrintAdminInfo()
        {
            SqlString = "Select * From Admin";
            return (objDataBaseOperateClass2.ShowTable(SqlString));
        }

        public DataTable PrintCourseInfo()
        {
            SqlString = "select CourseNum as �γ̺�,CourseName as �γ�����,Credit AS ѧ��,ProOrPub as רҵ�򹫹�,NeedOrOpt AS  ���� ,Department.DeptName as ϵ�� from dbo.Course join Department on Course.DeptNum=Department.DeptNum";
            return (objDataBaseOperateClass2.ShowTable(SqlString));
        }

        //��ӡ��ʦ��Ϣ��
        public DataTable PrintTeaInfo()
        {
            SqlString = "Select TeaNum AS ����,TeaName AS ����,TeaSex AS �Ա�, TeaAdress AS ��ϵ��ַ,TeaPhone AS ��ϵ�绰,TeaTitle AS ְ��,TeaProField AS רҵ���� From dbo.Teacher";

            return (objDataBaseOperateClass2.ShowTable(SqlString));
        }

        //��ӡ�༶�ɼ���
        public DataTable PrintClassScore()
        {
            SqlString = "Select * From dbo.V_ClassScoreSearch";
            return (objDataBaseOperateClass2.ShowTable(SqlString));
        }

    }
}
