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

## Kết quả đạt được
### Giao diện ứng dụng phía Client
Giao diện ứng dụng Windows Forms (`TemperatureClient`) bao gồm:
- Một ô nhập liệu (textbox) để nhập nhiệt độ cần chuyển đổi.
- Hai nút bấm (button):
   - `Convert to Celsius`: Chuyển đổi nhiệt độ từ Fahrenheit sang Celsius.
   - `Convert to Fahrenheit`: Chuyển đổi nhiệt độ từ Celsius sang Fahrenheit.
- Một nhãn (label) để hiển thị kết quả chuyển đổi.
Hình minh họa giao diện: Ứng dụng hiển thị giao diện đơn giản với các thành phần được bố trí rõ ràng (như trong hình).

### Kết quả khi thực thi
#### 1. Khi nhập một giá trị hợp lệ vào ô nhập liệu và nhấn `Convert to Celsius`:
- Ứng dụng gửi giá trị Fahrenheit tới dịch vụ web.
- Dịch vụ trả về giá trị Celsius tương ứng.
- Kết quả hiển thị trên nhãn lblResult (ví dụ: 32 Fahrenheit = 0 Celsius).
#### 2. Khi nhập một giá trị hợp lệ vào ô nhập liệu và nhấn `Convert to Fahrenheit`:
- Ứng dụng gửi giá trị Celsius tới dịch vụ web.
- Dịch vụ trả về giá trị Fahrenheit tương ứng.
- Kết quả hiển thị trên nhãn lblResult (ví dụ: 0 Celsius = 32 Fahrenheit).
#### 3. Nếu nhập một giá trị không hợp lệ (ví dụ: chuỗi ký tự thay vì số):
- Ứng dụng hiển thị thông báo lỗi yêu cầu nhập giá trị hợp lệ.
## Một số lưu ý khi sử dụng
- Đảm bảo rằng dịch vụ TemperatureServer đang chạy và có thể truy cập từ máy client.
- Đối với các lỗi kết nối hoặc sự cố dịch vụ, ứng dụng sẽ thông báo lỗi cụ thể để người dùng xử lý.
## Yêu cầu hệ thống
- Hệ điều hành Windows với .NET Framework 4.7 hoặc mới hơn.
- TemperatureServer phải đang hoạt động và có thể truy cập.
