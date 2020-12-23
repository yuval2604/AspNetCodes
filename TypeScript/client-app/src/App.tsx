import React, { Component } from "react";
import "./App.css";
import { Header } from "./components/Home/header";
import { About } from "./components/Home/about";

function App() {
  return (
    <div className="App">
      <Header />
      <About />
    </div>
  );
}

export default App;
