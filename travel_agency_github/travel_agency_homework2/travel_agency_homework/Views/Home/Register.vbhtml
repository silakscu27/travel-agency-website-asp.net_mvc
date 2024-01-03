<!doctype html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Register</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
</head>
<body>
    
    <form id="MainForm" class="w-25 m-4">
        <h2 class="mb-3">Register</h2>
        <div class="form-floating mb-3">
            <input type="text" class="form-control" id="usernameInp" placeholder="name">
            <label for="floatingInput">Username</label>
        </div>
        <div class="form-floating mb-3">
            <input type="email" class="form-control" id="emailInp" placeholder="name@example.com">
            <label for="floatingInput">Email address</label>
        </div>
        <div class="form-floating">
            <input type="password" class="form-control" id="passwordInp" placeholder="Password">
            <label for="floatingPassword">Password</label>
        </div>

        <button type="submit" class="btn btn-primary" style="float:right">Create New User</button>

        <a href="@Url.Action("Signin", "Home")">
            <button type="button" class="btn btn-primary me-2" style="float:right">Sign In</button>
        </a>

    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-kenU1KFdBIe4zVF0s0G1M5b4hcpxyD9F7jL+jjXkk+Q2h455rYXK/7HAuoJl+0I4" crossorigin="anonymous"></script>
    <script type="module">
        import { initializeApp } from "https://www.gstatic.com/firebasejs/10.7.1/firebase-app.js";
        import { getDatabase, set, ref } from "https://www.gstatic.com/firebasejs/10.7.1/firebase-database.js";
        import { getAuth, createUserWithEmailAndPassword } from "https://www.gstatic.com/firebasejs/10.7.1/firebase-auth.js";

        const firebaseConfig = {
            apiKey: "AIzaSyAyso_2NBynygUQml533i68TvHhwUVjGxY",
            authDomain: "travelusers.firebaseapp.com",
            databaseURL: "https://travelusers-default-rtdb.firebaseio.com",
            projectId: "travelusers",
            storageBucket: "travelusers.appspot.com",
            messagingSenderId: "769781709782",
            appId: "1:769781709782:web:0d464f881be7868ad7c277"
        };

        // Initialize Firebase
        const app = initializeApp(firebaseConfig);
        const db = getDatabase();
        const auth = getAuth(app);

        let emailInp = document.getElementById('emailInp');
        let usernameInp = document.getElementById('usernameInp');
        let passwordInp = document.getElementById('passwordInp');
        let MainForm = document.getElementById('MainForm');

        let RegisterUser = evt => {
            evt.preventDefault();
            createUserWithEmailAndPassword(auth, emailInp.value, passwordInp.value)
                .then((credentials) => {
                    console.log(credentials);
                })
                .catch((error) => {
                    alert(error.message);
                    console.log(error.code);
                    console.log(error.message);
                })
        }
        MainForm.addEventListener('submit', RegisterUser);

    </script>
</body>
</html>