import axios from "axios";

const HttpClient = axios.create({
    baseURL: "http://localhost:5000"
});

export default HttpClient;