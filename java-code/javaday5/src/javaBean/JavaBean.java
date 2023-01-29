package javaBean;

public class JavaBean {
    //标准JavaBean
    private String userName;
    private String idPassword;
    private String eMail;
    private String gendar;
    private int age;

    public JavaBean() {
    }

    public JavaBean(String userName, String idPassword, String eMail, String gendar, int age) {
        this.userName = userName;
        this.idPassword = idPassword;
        this.eMail = eMail;
        this.gendar = gendar;
        this.age = age;
    }

    /**
     * 获取
     * @return userName
     */
    public String getUserName() {
        return userName;
    }

    /**
     * 设置
     * @param userName
     */
    public void setUserName(String userName) {
        this.userName = userName;
    }

    /**
     * 获取
     * @return idPassword
     */
    public String getIdPassword() {
        return idPassword;
    }

    /**
     * 设置
     * @param idPassword
     */
    public void setIdPassword(String idPassword) {
        this.idPassword = idPassword;
    }

    /**
     * 获取
     * @return eMail
     */
    public String getEMail() {
        return eMail;
    }

    /**
     * 设置
     * @param eMail
     */
    public void setEMail(String eMail) {
        this.eMail = eMail;
    }

    /**
     * 获取
     * @return gendar
     */
    public String getGendar() {
        return gendar;
    }

    /**
     * 设置
     * @param gendar
     */
    public void setGendar(String gendar) {
        this.gendar = gendar;
    }

    /**
     * 获取
     * @return age
     */
    public int getAge() {
        return age;
    }

    /**
     * 设置
     * @param age
     */
    public void setAge(int age) {
        this.age = age;
    }


//快捷生成构造方法，一个不选时空参，按住shift全选有参  constructor
    //alt + insert
    //alt + fn + insert

    //快捷生成get和set 选择getter+setter

}
