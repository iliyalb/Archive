class Soldier
{
private:
    int m_Health;
    int m_Armor;
    int m_Range;
    int m_Power;
public:
    void setHealth(int h);
    void setArmor(int a);
    void setRange(int r);
    void setPower(int p);
    void shoot();
    void sprint();
    void crouch();
    void prone();
};

class Sniper : public Soldier
{
    public:
    Sniper::Sniper()
    {
        setHealth(100);
        setArmor(100);
        setRange(1000);
        setPower(1000);
    }
};