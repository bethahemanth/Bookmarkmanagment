const API_BASE_URL = "http://localhost:5288/api";

// Show method section
function showMethods(section) {
    document.getElementById("userMethods").style.display = "none";
    document.getElementById("eventMethods").style.display = "none";
    document.getElementById(section).style.display = "block";
}

// Show forms
function showForm(form) {
    document.querySelectorAll(".form-container").forEach(f => f.style.display = "none");
    document.getElementById(form).style.display = "block";
}

// Fetch users
async function fetchUsers() {
    const response = await fetch(`${API_BASE_URL}/User_Controller/GetAllUsers`);
    const users = await response.json();
    const userList = document.getElementById("userList");
    userList.innerHTML = "";

    users.forEach(user => {
        const row = document.createElement("tr");
        row.innerHTML = `<td>${user.id}</td><td>${user.name}</td><td>${user.email}</td>
            <td><button onclick="deleteUser(${user.id})" class="delete">Delete</button></td>`;
        userList.appendChild(row);
    });
}

// Add user
async function addUser() {
    const name = document.getElementById("userName").value;
    const email = document.getElementById("userEmail").value;

    await fetch(`${API_BASE_URL}/User_Controller/InsertUser`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ name, email })
    });

    fetchUsers();
}

// Update user
async function updateUser() {
    const id = document.getElementById("updateUserId").value;
    const name = document.getElementById("updateUserName").value;

    await fetch(`${API_BASE_URL}/User_Controller/UpdateUser`, {
        method: "PUT",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ id, name })
    });

    fetchUsers();
}

// Delete user
async function deleteUser(id) {
    await fetch(`${API_BASE_URL}/User_Controller/DeleteUserById?id=${id}`, { method: "DELETE" });
    fetchUsers();
}

// Fetch events
async function fetchEvents() {
    const response = await fetch(`${API_BASE_URL}/Event_Controller/GetAllEvents`);
    const events = await response.json();
    const eventList = document.getElementById("eventList");
    eventList.innerHTML = "";

    events.forEach(event => {
        const row = document.createElement("tr");
        row.innerHTML = `<td>${event.id}</td><td>${event.title}</td><td>${event.date}</td>
            <td><button onclick="deleteEvent(${event.id})" class="delete">Delete</button></td>`;
        eventList.appendChild(row);
    });
}

// Add event
async function addEvent() {
    const title = document.getElementById("eventTitle").value;
    const date = document.getElementById("eventDate").value;

    await fetch(`${API_BASE_URL}/Event_Controller/InsertEvent`, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ title, date })
    });

    fetchEvents();
}

// Delete event
async function deleteEvent(id) {
    await fetch(`${API_BASE_URL}/Event_Controller/DeleteEventById?id=${id}`, { method: "DELETE" });
    fetchEvents();
}
