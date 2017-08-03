uniform float     angle;
uniform vec2      resolution;

void main(void)
{
    vec2 p = gl_FragCoord.xy / resolution - 0.5;
    float a = mod(atan(p.y, p.x) / 6.2831853072 - angle, 1.0);
    a *= 1.0 - pow(cos(64.0 * 3.14159265358 * a), 16.0);
    gl_FragColor = vec4(1, 1, 1, a * 1.1 - 0.1);
}
