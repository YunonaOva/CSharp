// �������� � ����� ������� ���� Account.cs, � �������� � �� ����� public ����� Account. 

public class Account 
{
    //* �������� � ����� ���� _balance. ���� �������� ������������� private. 

    private int _balance;

    public int Balance;
    public int Add_sum;
    public static int Sum = 0;

    /*�������� � ���������� ��� ������: AddMoney, TakeMoney, ShowBalance.
    * ����� AddMoney ����������� �������� _balance �� ��������� ��������. 
    * ����� TakeMoney ��������� �������� _balance �� ��������� �����. 
    * ����� ShowBalance ���������� �������� _balance. ������, ��� �� � ����� �� ������� �� ������ ���� ������ � ��������.*/

    public AddMoney(int _balance, int add_sum) 
    {
        Balance = _balance;

        Add_sum = add_sum;

        Sum = _balance + add_sum;  


    }


}