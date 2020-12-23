import React, { useState } from "react";
import { Link } from "react-router-dom";
import { Container } from "react-bootstrap";

function PageB() {
  const [count, setCount] = useState(0);

  return (
    <Container>
      <button onClick={() => setCount(count + 1)}>Count {count}</button>
      <Link to="/">Navigate to Login</Link>
    </Container>
  );
}

export default PageB;
