import axios from "axios"

export const StudentFinderClient = axios.create({
    baseURL :"http://localhost:5077/api/users/",
    headers : {
        "Content-Type": "application/json",
        timeout : 3000
    }
})

export const url_search = "/by-name/"
