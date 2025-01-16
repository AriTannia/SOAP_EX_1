# README - Temperature Web Service và Temperature Client

## Giới thiệu
Dự án bao gồm hai thành phần:
- **TemperatureServer**: Một dịch vụ web SOAP cung cấp các phương thức để chuyển đổi nhiệt độ giữa Fahrenheit và Celsius.
- **TemperatureClient**: Một ứng dụng Windows Forms cho phép người dùng sử dụng giao diện để thực hiện các chuyển đổi nhiệt độ thông qua dịch vụ web.

---

## Cấu trúc dự án

### 1. TemperatureServer
#### **WebService1.asmx** (Dịch vụ Web)
- `FahrenheitToCelsius(double fahrenheit)`: Chuyển đổi nhiệt độ từ Fahrenheit sang Celsius.
- `CelsiusToFahrenheit(double celsius)`: Chuyển đổi nhiệt độ từ Celsius sang Fahrenheit.

**Ví dụ:**
- `FahrenheitToCelsius(32)` trả về `0.0`.
- `CelsiusToFahrenheit(0)` trả về `32.0`.

#### **Namespace**: `TemperatureWS`
Dịch vụ sử dụng namespace mặc định `http://tempuri.org/`.

---

### 2. TemperatureClient
Ứng dụng Windows Forms cho phép nhập nhiệt độ và hiển thị kết quả chuyển đổi.

#### **Form1.cs**
Các thành phần chính:
- **Textbox `txtInput`**: Nhập nhiệt độ đầu vào.
- **Label `lblResult`**: Hiển thị kết quả chuyển đổi.
- **Button `btnToCelsius`**: Chuyển đổi từ Fahrenheit sang Celsius.
- **Button `btnToFahrenheit`**: Chuyển đổi từ Celsius sang Fahrenheit.

**Phương thức xử lý:**
- `btnToCelsius_Click`: 
  - Chuyển đổi giá trị Fahrenheit từ ô nhập liệu.
  - Gọi phương thức `FahrenheitToCelsiusAsync` từ dịch vụ web và hiển thị kết quả.
- `btnToFahrenheit_Click`:
  - Chuyển đổi giá trị Celsius từ ô nhập liệu.
  - Gọi phương thức `CelsiusToFahrenheitAsync` từ dịch vụ web và hiển thị kết quả.

**Xử lý lỗi:**
- Kiểm tra đầu vào hợp lệ bằng `double.TryParse`.  
- Hiển thị thông báo lỗi nếu nhập sai định dạng hoặc có sự cố kết nối.

---

## Hướng dẫn kết nối TemperatureClient với TemperatureServer
#### 1. Nhấp chuột phải vào dự án **TemperatureClient** trong **Solution Explorer**.
#### 2. Chọn **Add** > **Service Reference**.
#### 3. Trong cửa sổ **Add Service Reference**, chọn **Advanced**.
#### 4. Chọn **Add Web Reference**.
#### 5. Nhập URL của **TemperatureServer** (ví dụ: `http://localhost:port/WebService1.asmx`).
#### 6. Nhấn **Go** để tải thông tin dịch vụ.
#### 7. Chọn dịch vụ và nhấn **Add Reference** để hoàn tất.

---

## Hướng dẫn sử dụng
#### 1. Khởi chạy ứng dụng **TemperatureClient.exe**.
#### 2. Nhập nhiệt độ vào ô nhập liệu.
#### 3. Nhấn nút **Convert to Celsius** hoặc **Convert to Fahrenheit** để thực hiện chuyển đổi và hiển thị kết quả.

---

## Yêu cầu hệ thống
- Hệ điều hành Windows với .NET Framework 4.7 hoặc mới hơn.
- TemperatureServer phải đang hoạt động và có thể truy cập.
