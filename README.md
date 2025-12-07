
# 🍢 **Kebabs Delivery – Desktop Delivery Management System**

### **C# WinForms · In-Memory Data · Multi-Role Workflow**

Kebabs Delivery is a desktop application that simulates a complete food-delivery workflow across four roles: **Customer, Restaurant, Courier, and Admin**.
The system uses an **in-memory database**, so it requires **no SQL setup** and runs instantly.

## **Main Features**

### **Customer Panel**

* Browse restaurants
* View menus & add items to cart
* Place orders
* Track live order status
* Receive notifications on **rejected**, **picked up**, and **delivered** orders

---

### **Restaurant Panel**

* View all incoming orders
* Accept / Reject orders (with restrictions)
* Mark orders as **Preparing**
* Mark as **Ready for Pickup**
* Completed or rejected orders auto-removed

---

### **Courier Panel**

* View assigned deliveries
* See pickup & drop-off addresses
* Mark as **Picked Up**
* Mark as **Delivered**
* Delivered orders auto-removed

---

### **Admin Panel**

* View all users (Customers, Restaurants, Couriers, Admins)
* View restaurants
* View system-wide order & delivery logs
* Basic system monitoring tools

---

## **Architecture Overview**

### **Models**

`User`, `Restaurant`, `Food`, `Order`, `OrderItem`, `Delivery`

### **Services**

`AuthService`, `OrderService`, `DeliveryService`, `RestaurantService`, `MenuService`

### **Data**

`InMemoryDatabase.cs` — stores Users, Restaurants, Orders, Deliveries, Menus

### **UI Forms**

`CustomerForm`, `RestaurantForm`, `CourierForm`, `AdminForm`, `RegisterForm`, `LoginForm`

---

##**How to Run**

1. Clone the repository
2. Open solution in **Visual Studio**
3. Press **F5**

**Default credentials:**

| Role       | Username  | Password |
| ---------- | --------- | -------- |
| Customer   | customer1 | 123      |
| Restaurant | rest1     | 123      |
| Courier    | courier1  | 123      |
| Admin      | admin     | 123      |

---

## **Future Improvements**

* SQL/EF Core database migration
* Customer order history
* Admin editing tools
* Additional courier routing logic

---

## Contribution

Feel free to open issues or submit pull requests.


