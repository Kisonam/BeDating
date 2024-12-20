# BeDating

**BeDating**  
*"BeDating – the platform for dating and messaging, making it easy to connect with new people."*

---

## Description

BeDating solves the common challenge of finding the right match in today’s busy world. Whether you're searching for friendship, romance, or simply meaningful connections, BeDating provides an intuitive and flexible experience tailored to your needs.

The project reimagines the concept of dating websites, focusing on simplicity, user comfort, and a seamless experience. With a sleek and user-friendly design, BeDating ensures that you can focus on what truly matters: meeting the right people.  

**Why BeDating?**  
- Say goodbye to clutter – only essential features to help you connect.  
- Flexible filters to find matches that suit your preferences.  
- Built-in chat for smooth communication.  
- Secure and straightforward, offering everything you need without distractions.  

Whether you're new to online dating or a seasoned user, BeDating redefines how people connect by combining simplicity, elegance, and powerful functionality.  

---

## Features

- **Likes system:**  
  - Send likes to profiles you find interesting.  
  - Receive likes from others.  
  - Match when there’s mutual interest.  

- **Messaging:**  
  - Start conversations instantly with your matches.  
  - Chat interface designed for a smooth and enjoyable experience.  

- **Profile management:**  
  - Upload and manage your photos.  
  - Edit your personal information effortlessly.  

- **Filters:**  
  - Search for profiles by age, interests, and other criteria.  
  - Customize your search to find your ideal match.  

- **Minimalistic approach:**  
  - No unnecessary distractions – only what you need to connect.  

---

## Installation

To run BeDating locally, follow these steps:  

```bash
# Clone the repository
git clone https://github.com/username/BeDating.git  

# Navigate to the API directory
cd API/  

# Install dependencies and start the backend server
npm install  
dotnet run  
```

---

## Usage

BeDating is built using Angular for the frontend and ASP.NET Core for the backend. Below are the main technologies and libraries used, and how to integrate them into the project.

### **Frontend Styles and Libraries**

The following stylesheets are included for styling the app:  
- `bootstrap.min.css` (core Bootstrap for responsive design).  
- `ngx-bootstrap/datepicker/bs-datepicker.css` (for datepickers).  
- `font-awesome.min.css` (icon library).  
- `bootswatch/quartz/bootstrap.min.css` (custom Quartz theme for Bootstrap).  
- `ngx-toastr/toastr.css` (for displaying toast notifications).  
- `ngx-spinner/animations/line-scale-party.css` (for loading animations).  
- `src/styles.css` (custom project-specific styles).

### **Angular Libraries**

The project uses the following key Angular-based packages:
- **`NgxSpinner`**: For animated loading spinners.  
  ```typescript
  import { NgxSpinnerComponent } from 'ngx-spinner';
## Backend Dependencies

The backend is built using **ASP.NET Core** and includes several important libraries for authentication, database management, file handling, and API documentation.

### **Authentication and Authorization:**
- `Microsoft.AspNetCore.Authentication.JwtBearer`: Used for handling JWT tokens for secure authentication across the API.
- `System.IdentityModel.Tokens.Jwt`: Library for creating and validating JWT tokens.

### **Entity Framework Core:**
- `Microsoft.EntityFrameworkCore`: Core package for interacting with databases using Entity Framework.
- `Microsoft.EntityFrameworkCore.Sqlite`: Adds support for SQLite databases for lightweight data storage.
- `Microsoft.EntityFrameworkCore.Tools`: For managing migrations and performing database updates.
- `Microsoft.EntityFrameworkCore.Design`: Provides tools for database design and migration management.

### **File Storage:**
- `CloudinaryDotNet`: Used for integrating Cloudinary for media file uploads, storage, and processing.

### **API Documentation:**
- `Swashbuckle.AspNetCore`: Adds Swagger support for generating interactive API documentation.

### **Identity and Authorization:**
- `Microsoft.AspNetCore.Identity.EntityFrameworkCore`: Integrates ASP.NET Core Identity with Entity Framework for secure user management (e.g., registration, login, roles).

### **Additional Dependencies:**
- `Microsoft.AspNetCore`: Core ASP.NET Core library for middleware, request handling, and server-side processing.

---

## Contributors

The development of BeDating involved significant time and effort from the whole team. We worked through numerous challenges and bugs to deliver the final product.

### Key Team Members:
- **Anna Kuchunska** – Lead Designer: Responsible for the overall design, user interface, and user experience.
- **Maksym Putra** – Lead Frontend Developer: Managed the frontend development, ensuring the app's UI/UX was both functional and intuitive.
- **Volodymyr Cherevatyi** – Frontend Developer: Contributed to frontend development, implementing core features and responsive design.
- **Artem Radovskyi** – Lead Backend Developer: Led backend development, ensuring the app was secure, reliable, and efficient.

Special thanks to the entire team for their dedication and hard work! There were many bugs along the way, but we persevered and made it through!

---

## License

This project is licensed under the MIT License.

---

## Contact

For any questions or suggestions, feel free to reach out to us at:

**Email**: [kisonamplay92@gmail.com](mailto:kisonamplay92@gmail.com)

---
