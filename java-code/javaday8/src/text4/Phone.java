package text4;

public class Phone {
    private String brand;
    private double price;
    private String coloe;

    public Phone() {
    }

    public Phone(String brand, double price, String coloe) {
        this.brand = brand;
        this.price = price;
        this.coloe = coloe;
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public String getColoe() {
        return coloe;
    }

    public void setColoe(String coloe) {
        this.coloe = coloe;
    }
}
