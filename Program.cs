

class Building
{
    private int _numberOfFloors;
    private double _size;

    public Building(int numberOfFloors, double size)
    {
        _numberOfFloors = numberOfFloors;
        _size = size;
    }

    public Building(int numberOfFloors)
    {
        _numberOfFloors = numberOfFloors;
        _size = 3 * _numberOfFloors;
    }

    public double GetFloorMaxSize()
    {
        if (_numberOfFloors > 0)
        {
            return _size / _numberOfFloors;
        }
        else
        {
            return 0;
        }
    }

    public int GetFloorCount()
    {
        return _numberOfFloors;
    }

    public double GetSize()
    {
        return _size;
    }
}