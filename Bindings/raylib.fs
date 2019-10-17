module Raylib
open System
open System.Runtime.InteropServices
type ConfigFlag =
|FLAG_RESERVED = 1
|FLAG_FULLSCREEN_MODE = 2
|FLAG_WINDOW_RESIZABLE = 4
|FLAG_WINDOW_UNDECORATED = 8
|FLAG_WINDOW_TRANSPARENT = 16
|FLAG_WINDOW_HIDDEN = 128
|FLAG_WINDOW_ALWAYS_RUN = 256
|FLAG_MSAA_4X_HINT = 32
|FLAG_VSYNC_HINT = 64
and TraceLogType =
|LOG_ALL = 0
|LOG_TRACE = 1
|LOG_DEBUG = 2
|LOG_INFO = 3
|LOG_WARNING = 4
|LOG_ERROR = 5
|LOG_FATAL = 6
|LOG_NONE = 7
and KeyboardKey =
|KEY_APOSTROPHE = 39
|KEY_COMMA = 44
|KEY_MINUS = 45
|KEY_PERIOD = 46
|KEY_SLASH = 47
|KEY_ZERO = 48
|KEY_ONE = 49
|KEY_TWO = 50
|KEY_THREE = 51
|KEY_FOUR = 52
|KEY_FIVE = 53
|KEY_SIX = 54
|KEY_SEVEN = 55
|KEY_EIGHT = 56
|KEY_NINE = 57
|KEY_SEMICOLON = 59
|KEY_EQUAL = 61
|KEY_A = 65
|KEY_B = 66
|KEY_C = 67
|KEY_D = 68
|KEY_E = 69
|KEY_F = 70
|KEY_G = 71
|KEY_H = 72
|KEY_I = 73
|KEY_J = 74
|KEY_K = 75
|KEY_L = 76
|KEY_M = 77
|KEY_N = 78
|KEY_O = 79
|KEY_P = 80
|KEY_Q = 81
|KEY_R = 82
|KEY_S = 83
|KEY_T = 84
|KEY_U = 85
|KEY_V = 86
|KEY_W = 87
|KEY_X = 88
|KEY_Y = 89
|KEY_Z = 90
|KEY_SPACE = 32
|KEY_ESCAPE = 256
|KEY_ENTER = 257
|KEY_TAB = 258
|KEY_BACKSPACE = 259
|KEY_INSERT = 260
|KEY_DELETE = 261
|KEY_RIGHT = 262
|KEY_LEFT = 263
|KEY_DOWN = 264
|KEY_UP = 265
|KEY_PAGE_UP = 266
|KEY_PAGE_DOWN = 267
|KEY_HOME = 268
|KEY_END = 269
|KEY_CAPS_LOCK = 280
|KEY_SCROLL_LOCK = 281
|KEY_NUM_LOCK = 282
|KEY_PRINT_SCREEN = 283
|KEY_PAUSE = 284
|KEY_F1 = 290
|KEY_F2 = 291
|KEY_F3 = 292
|KEY_F4 = 293
|KEY_F5 = 294
|KEY_F6 = 295
|KEY_F7 = 296
|KEY_F8 = 297
|KEY_F9 = 298
|KEY_F10 = 299
|KEY_F11 = 300
|KEY_F12 = 301
|KEY_LEFT_SHIFT = 340
|KEY_LEFT_CONTROL = 341
|KEY_LEFT_ALT = 342
|KEY_LEFT_SUPER = 343
|KEY_RIGHT_SHIFT = 344
|KEY_RIGHT_CONTROL = 345
|KEY_RIGHT_ALT = 346
|KEY_RIGHT_SUPER = 347
|KEY_KB_MENU = 348
|KEY_LEFT_BRACKET = 91
|KEY_BACKSLASH = 92
|KEY_RIGHT_BRACKET = 93
|KEY_GRAVE = 96
|KEY_KP_0 = 320
|KEY_KP_1 = 321
|KEY_KP_2 = 322
|KEY_KP_3 = 323
|KEY_KP_4 = 324
|KEY_KP_5 = 325
|KEY_KP_6 = 326
|KEY_KP_7 = 327
|KEY_KP_8 = 328
|KEY_KP_9 = 329
|KEY_KP_DECIMAL = 330
|KEY_KP_DIVIDE = 331
|KEY_KP_MULTIPLY = 332
|KEY_KP_SUBTRACT = 333
|KEY_KP_ADD = 334
|KEY_KP_ENTER = 335
|KEY_KP_EQUAL = 336
and AndroidButton =
|KEY_BACK = 4
|KEY_MENU = 82
|KEY_VOLUME_UP = 24
|KEY_VOLUME_DOWN = 25
and MouseButton =
|MOUSE_LEFT_BUTTON = 0
|MOUSE_RIGHT_BUTTON = 1
|MOUSE_MIDDLE_BUTTON = 2
and GamepadNumber =
|GAMEPAD_PLAYER1 = 0
|GAMEPAD_PLAYER2 = 1
|GAMEPAD_PLAYER3 = 2
|GAMEPAD_PLAYER4 = 3
and GamepadButton =
|GAMEPAD_BUTTON_UNKNOWN = 0
|GAMEPAD_BUTTON_LEFT_FACE_UP = 1
|GAMEPAD_BUTTON_LEFT_FACE_RIGHT = 2
|GAMEPAD_BUTTON_LEFT_FACE_DOWN = 3
|GAMEPAD_BUTTON_LEFT_FACE_LEFT = 4
|GAMEPAD_BUTTON_RIGHT_FACE_UP = 5
|GAMEPAD_BUTTON_RIGHT_FACE_RIGHT = 6
|GAMEPAD_BUTTON_RIGHT_FACE_DOWN = 7
|GAMEPAD_BUTTON_RIGHT_FACE_LEFT = 8
|GAMEPAD_BUTTON_LEFT_TRIGGER_1 = 9
|GAMEPAD_BUTTON_LEFT_TRIGGER_2 = 10
|GAMEPAD_BUTTON_RIGHT_TRIGGER_1 = 11
|GAMEPAD_BUTTON_RIGHT_TRIGGER_2 = 12
|GAMEPAD_BUTTON_MIDDLE_LEFT = 13
|GAMEPAD_BUTTON_MIDDLE = 14
|GAMEPAD_BUTTON_MIDDLE_RIGHT = 15
|GAMEPAD_BUTTON_LEFT_THUMB = 16
|GAMEPAD_BUTTON_RIGHT_THUMB = 17
and GamepadAxis =
|GAMEPAD_AXIS_UNKNOWN = 0
|GAMEPAD_AXIS_LEFT_X = 1
|GAMEPAD_AXIS_LEFT_Y = 2
|GAMEPAD_AXIS_RIGHT_X = 3
|GAMEPAD_AXIS_RIGHT_Y = 4
|GAMEPAD_AXIS_LEFT_TRIGGER = 5
|GAMEPAD_AXIS_RIGHT_TRIGGER = 6
and ShaderLocationIndex =
|LOC_VERTEX_POSITION = 0
|LOC_VERTEX_TEXCOORD01 = 1
|LOC_VERTEX_TEXCOORD02 = 2
|LOC_VERTEX_NORMAL = 3
|LOC_VERTEX_TANGENT = 4
|LOC_VERTEX_COLOR = 5
|LOC_MATRIX_MVP = 6
|LOC_MATRIX_MODEL = 7
|LOC_MATRIX_VIEW = 8
|LOC_MATRIX_PROJECTION = 9
|LOC_VECTOR_VIEW = 10
|LOC_COLOR_DIFFUSE = 11
|LOC_COLOR_SPECULAR = 12
|LOC_COLOR_AMBIENT = 13
|LOC_MAP_ALBEDO = 14
|LOC_MAP_METALNESS = 15
|LOC_MAP_NORMAL = 16
|LOC_MAP_ROUGHNESS = 17
|LOC_MAP_OCCLUSION = 18
|LOC_MAP_EMISSION = 19
|LOC_MAP_HEIGHT = 20
|LOC_MAP_CUBEMAP = 21
|LOC_MAP_IRRADIANCE = 22
|LOC_MAP_PREFILTER = 23
|LOC_MAP_BRDF = 24
and ShaderUniformDataType =
|UNIFORM_FLOAT = 0
|UNIFORM_VEC2 = 1
|UNIFORM_VEC3 = 2
|UNIFORM_VEC4 = 3
|UNIFORM_INT = 4
|UNIFORM_IVEC2 = 5
|UNIFORM_IVEC3 = 6
|UNIFORM_IVEC4 = 7
|UNIFORM_SAMPLER2D = 8
and MaterialMapType =
|MAP_ALBEDO = 0
|MAP_METALNESS = 1
|MAP_NORMAL = 2
|MAP_ROUGHNESS = 3
|MAP_OCCLUSION = 4
|MAP_EMISSION = 5
|MAP_HEIGHT = 6
|MAP_CUBEMAP = 7
|MAP_IRRADIANCE = 8
|MAP_PREFILTER = 9
|MAP_BRDF = 10
and PixelFormat =
|UNCOMPRESSED_GRAYSCALE = 1
|UNCOMPRESSED_GRAY_ALPHA = 2
|UNCOMPRESSED_R5G6B5 = 3
|UNCOMPRESSED_R8G8B8 = 4
|UNCOMPRESSED_R5G5B5A1 = 5
|UNCOMPRESSED_R4G4B4A4 = 6
|UNCOMPRESSED_R8G8B8A8 = 7
|UNCOMPRESSED_R32 = 8
|UNCOMPRESSED_R32G32B32 = 9
|UNCOMPRESSED_R32G32B32A32 = 10
|COMPRESSED_DXT1_RGB = 11
|COMPRESSED_DXT1_RGBA = 12
|COMPRESSED_DXT3_RGBA = 13
|COMPRESSED_DXT5_RGBA = 14
|COMPRESSED_ETC1_RGB = 15
|COMPRESSED_ETC2_RGB = 16
|COMPRESSED_ETC2_EAC_RGBA = 17
|COMPRESSED_PVRT_RGB = 18
|COMPRESSED_PVRT_RGBA = 19
|COMPRESSED_ASTC_4x4_RGBA = 20
|COMPRESSED_ASTC_8x8_RGBA = 21
and TextureFilterMode =
|FILTER_POINT = 0
|FILTER_BILINEAR = 1
|FILTER_TRILINEAR = 2
|FILTER_ANISOTROPIC_4X = 3
|FILTER_ANISOTROPIC_8X = 4
|FILTER_ANISOTROPIC_16X = 5
and CubemapLayoutType =
|CUBEMAP_AUTO_DETECT = 0
|CUBEMAP_LINE_VERTICAL = 1
|CUBEMAP_LINE_HORIZONTAL = 2
|CUBEMAP_CROSS_THREE_BY_FOUR = 3
|CUBEMAP_CROSS_FOUR_BY_THREE = 4
|CUBEMAP_PANORAMA = 5
and TextureWrapMode =
|WRAP_REPEAT = 0
|WRAP_CLAMP = 1
|WRAP_MIRROR_REPEAT = 2
|WRAP_MIRROR_CLAMP = 3
and FontType =
|FONT_DEFAULT = 0
|FONT_BITMAP = 1
|FONT_SDF = 2
and BlendMode =
|BLEND_ALPHA = 0
|BLEND_ADDITIVE = 1
|BLEND_MULTIPLIED = 2
and GestureType =
|GESTURE_NONE = 0
|GESTURE_TAP = 1
|GESTURE_DOUBLETAP = 2
|GESTURE_HOLD = 4
|GESTURE_DRAG = 8
|GESTURE_SWIPE_RIGHT = 16
|GESTURE_SWIPE_LEFT = 32
|GESTURE_SWIPE_UP = 64
|GESTURE_SWIPE_DOWN = 128
|GESTURE_PINCH_IN = 256
|GESTURE_PINCH_OUT = 512
and CameraMode =
|CAMERA_CUSTOM = 0
|CAMERA_FREE = 1
|CAMERA_ORBITAL = 2
|CAMERA_FIRST_PERSON = 3
|CAMERA_THIRD_PERSON = 4
and CameraType =
|CAMERA_PERSPECTIVE = 0
|CAMERA_ORTHOGRAPHIC = 1
and NPatchType =
|NPT_9PATCH = 0
|NPT_3PATCH_VERTICAL = 1
|NPT_3PATCH_HORIZONTAL = 2
and Vector2 =
  struct
    val x: float
    val y: float
  end
and Vector3 =
  struct
    val x: float
    val y: float
    val z: float
  end
and Vector4 =
  struct
    val x: float
    val y: float
    val z: float
    val w: float
  end
and Matrix =
  struct
    val M0: float
    val M4: float
    val M8: float
    val M12: float
    val M1: float
    val M5: float
    val M9: float
    val M13: float
    val M2: float
    val M6: float
    val M10: float
    val M14: float
    val M3: float
    val M7: float
    val M11: float
    val M15: float
  end
and Color =
  struct
    val r: byte
    val g: byte
    val b: byte
    val a: byte
  end
and Rectangle =
  struct
    val x: float
    val y: float
    val Width: float
    val Height: float
  end
and Image =
  struct
    val Data: IntPtr
    val Width: int
    val Height: int
    val Mipmaps: int
    val Format: int
  end
and Texture2D =
  struct
    val Id: uint32
    val Width: int
    val Height: int
    val Mipmaps: int
    val Format: int
  end
and RenderTexture2D =
  struct
    val Id: uint32
    val Texture: Texture2D
    val Depth: Texture2D
    val DepthTexture: bool
  end
and NPatchInfo =
  struct
    val SourceRec: Rectangle
    val Left: int
    val Top: int
    val Right: int
    val Bottom: int
    val Type: int
  end
and CharInfo =
  struct
    val Value: int
    val OffsetX: int
    val OffsetY: int
    val AdvanceX: int
    val Image: Image
  end
and Font =
  struct
    val BaseSize: int
    val CharsCount: int
    val Texture: Texture2D
    val Recs: Rectangle[]
    val Chars: CharInfo[]
  end
and Camera3D =
  struct
    val Position: Vector3
    val Target: Vector3
    val Up: Vector3
    val Fovy: float
    val Type: int
  end
and Camera2D =
  struct
    val Offset: Vector2
    val Target: Vector2
    val Rotation: float
    val Zoom: float
  end
and Mesh =
  struct
    val VertexCount: int
    val TriangleCount: int
    val Vertices: float[]
    val Texcoords: float[]
    val Texcoords2: float[]
    val Normals: float[]
    val Tangents: float[]
    val Colors: byte
    val Indices: uint16
    val AnimVertices: float[]
    val AnimNormals: float[]
    val BoneIds: int[]
    val BoneWeights: float[]
    val VaoId: uint32
    val VboId: uint32
  end
and Shader =
  struct
    val Id: uint32
    val Locs: int[]
  end
and MaterialMap =
  struct
    val Texture: Texture2D
    val Color: Color
    val Value: float
  end
and Material =
  struct
    val Shader: Shader
    val Maps: MaterialMap[]
    val Params: float[]
  end
and Transform =
  struct
    val Translation: Vector3
    val Rotation: Quaternion
    val Scale: Vector3
  end
and BoneInfo =
  struct
    val Name: string
    val Parent: int
  end
and Model =
  struct
    val Transform: Matrix
    val MeshCount: int
    val Meshes: Mesh[]
    val MaterialCount: int
    val Materials: Material[]
    val MeshMaterial: int[]
    val BoneCount: int
    val Bones: BoneInfo[]
    val BindPose: Transform[]
  end
and ModelAnimation =
  struct
    val BoneCount: int
    val Bones: BoneInfo[]
    val FrameCount: int
    val FramePoses: Transform[][]
  end
and Ray =
  struct
    val Position: Vector3
    val Direction: Vector3
  end
and RayHitInfo =
  struct
    val Hit: bool
    val Distance: float
    val Position: Vector3
    val Normal: Vector3
  end
and BoundingBox =
  struct
    val Min: Vector3
    val Max: Vector3
  end
and Wave =
  struct
    val SampleCount: uint32
    val SampleRate: uint32
    val SampleSize: uint32
    val Channels: uint32
    val Data: IntPtr
  end
and rAudioBuffer =
  struct
  end
and AudioStream =
  struct
    val SampleRate: uint32
    val SampleSize: uint32
    val Channels: uint32
    val Buffer: rAudioBuffer[]
  end
and Sound =
  struct
    val SampleCount: uint32
    val Stream: AudioStream
  end
and Music =
  struct
    val CtxType: int
    val CtxData: IntPtr
    val SampleCount: uint32
    val LoopCount: uint32
    val Stream: AudioStream
  end
and VrDeviceInfo =
  struct
    val HResolution: int
    val VResolution: int
    val HScreenSize: float
    val VScreenSize: float
    val VScreenCenter: float
    val EyeToScreenDistance: float
    val LensSeparationDistance: float
    val InterpupillaryDistance: float
    val LensDistortionValues: Vector4
    val ChromaAbCorrection: Vector4
  end
and Quaternion = Vector4
and Texture = Texture2D
and TextureCubemap = Texture2D
and RenderTexture = RenderTexture2D
and Camera = Camera3D
//and TraceLogCallback = void (*)(int logType, const char* text, va_list args)*
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void InitWindow (int width, int height, string title)
let niceInitWindow (width : int) (height : int) (title : string) = InitWindow(width, height, title)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool WindowShouldClose ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void CloseWindow ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsWindowReady ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsWindowMinimized ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsWindowResized ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsWindowHidden ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ToggleFullscreen ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnhideWindow ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void HideWindow ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetWindowIcon (Image image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetWindowTitle (string title)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetWindowPosition (int x, int y)
let niceSetWindowPosition (x : int) (y : int) = SetWindowPosition(x, y)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetWindowMonitor (int monitor)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetWindowMinSize (int width, int height)
let niceSetWindowMinSize (width : int) (height : int) = SetWindowMinSize(width, height)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetWindowSize (int width, int height)
let niceSetWindowSize (width : int) (height : int) = SetWindowSize(width, height)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern IntPtr GetWindowHandle ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetScreenWidth ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetScreenHeight ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetMonitorCount ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetMonitorWidth (int monitor)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetMonitorHeight (int monitor)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetMonitorPhysicalWidth (int monitor)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetMonitorPhysicalHeight (int monitor)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Vector2 GetWindowPosition ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string GetMonitorName (int monitor)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string GetClipboardText ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetClipboardText (string text)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ShowCursor ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void HideCursor ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsCursorHidden ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void EnableCursor ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DisableCursor ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ClearBackground (Color color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void BeginDrawing ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void EndDrawing ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void BeginMode2D (Camera2D camera)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void EndMode2D ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void BeginMode3D (Camera3D camera)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void EndMode3D ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void BeginTextureMode (RenderTexture2D target)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void EndTextureMode ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void BeginScissorMode (int x, int y, int width, int height)
let niceBeginScissorMode (x : int) (y : int) (width : int) (height : int) = BeginScissorMode(x, y, width, height)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void EndScissorMode ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Ray GetMouseRay (Vector2 mousePosition, Camera camera)
let niceGetMouseRay (mousePosition : Vector2) (camera : Camera) = GetMouseRay(mousePosition, camera)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Matrix GetCameraMatrix (Camera camera)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Matrix GetCameraMatrix2D (Camera2D camera)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Vector2 GetWorldToScreen (Vector3 position, Camera camera)
let niceGetWorldToScreen (position : Vector3) (camera : Camera) = GetWorldToScreen(position, camera)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Vector2 GetWorldToScreen2D (Vector2 position, Camera2D camera)
let niceGetWorldToScreen2D (position : Vector2) (camera : Camera2D) = GetWorldToScreen2D(position, camera)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Vector2 GetScreenToWorld2D (Vector2 position, Camera2D camera)
let niceGetScreenToWorld2D (position : Vector2) (camera : Camera2D) = GetScreenToWorld2D(position, camera)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetTargetFPS (int fps)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetFPS ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern float GetFrameTime ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern double GetTime ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int ColorToInt (Color color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Vector4 ColorNormalize (Color color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Vector3 ColorToHSV (Color color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Color ColorFromHSV (Vector3 hsv)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Color GetColor (int hexValue)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Color Fade (Color color, float alpha)
let niceFade (color : Color) (alpha : float) = Fade(color, alpha)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetConfigFlags (uint32 flags)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetTraceLogLevel (int logType)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetTraceLogExit (int logType)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetTraceLogCallback (TraceLogCallback callback)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void TraceLog (int logType, string text)
let niceTraceLog (logType : int) (text : string) = TraceLog(logType, text)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void TakeScreenshot (string fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetRandomValue (int min, int max)
let niceGetRandomValue (min : int) (max : int) = GetRandomValue(min, max)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool FileExists (string fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsFileExtension (string fileName, string ext)
let niceIsFileExtension (fileName : string) (ext : string) = IsFileExtension(fileName, ext)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool DirectoryExists (string dirPath)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string GetExtension (string fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string GetFileName (string filePath)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string GetFileNameWithoutExt (string filePath)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string GetDirectoryPath (string filePath)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string GetPrevDirectoryPath (string dirPath)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string GetWorkingDirectory ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern char[][] GetDirectoryFiles (string dirPath, int[] count)
let niceGetDirectoryFiles (dirPath : string) (count : int[]) = GetDirectoryFiles(dirPath, count)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ClearDirectoryFiles ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool ChangeDirectory (string dir)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsFileDropped ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern char[][] GetDroppedFiles (int[] count)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ClearDroppedFiles ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetFileModTime (string fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern byte CompressData (byte data, int dataLength, int[] compDataLength)
let niceCompressData (data : byte) (dataLength : int) (compDataLength : int[]) = CompressData(data, dataLength, compDataLength)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern byte DecompressData (byte compData, int compDataLength, int[] dataLength)
let niceDecompressData (compData : byte) (compDataLength : int) (dataLength : int[]) = DecompressData(compData, compDataLength, dataLength)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void StorageSaveValue (int position, int value)
let niceStorageSaveValue (position : int) (value : int) = StorageSaveValue(position, value)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int StorageLoadValue (int position)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void OpenURL (string url)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsKeyPressed (int key)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsKeyDown (int key)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsKeyReleased (int key)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsKeyUp (int key)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetKeyPressed ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetExitKey (int key)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsGamepadAvailable (int gamepad)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsGamepadName (int gamepad, string name)
let niceIsGamepadName (gamepad : int) (name : string) = IsGamepadName(gamepad, name)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string GetGamepadName (int gamepad)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsGamepadButtonPressed (int gamepad, int button)
let niceIsGamepadButtonPressed (gamepad : int) (button : int) = IsGamepadButtonPressed(gamepad, button)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsGamepadButtonDown (int gamepad, int button)
let niceIsGamepadButtonDown (gamepad : int) (button : int) = IsGamepadButtonDown(gamepad, button)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsGamepadButtonReleased (int gamepad, int button)
let niceIsGamepadButtonReleased (gamepad : int) (button : int) = IsGamepadButtonReleased(gamepad, button)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsGamepadButtonUp (int gamepad, int button)
let niceIsGamepadButtonUp (gamepad : int) (button : int) = IsGamepadButtonUp(gamepad, button)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetGamepadButtonPressed ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetGamepadAxisCount (int gamepad)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern float GetGamepadAxisMovement (int gamepad, int axis)
let niceGetGamepadAxisMovement (gamepad : int) (axis : int) = GetGamepadAxisMovement(gamepad, axis)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsMouseButtonPressed (int button)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsMouseButtonDown (int button)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsMouseButtonReleased (int button)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsMouseButtonUp (int button)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetMouseX ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetMouseY ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Vector2 GetMousePosition ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetMousePosition (int x, int y)
let niceSetMousePosition (x : int) (y : int) = SetMousePosition(x, y)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetMouseOffset (int offsetX, int offsetY)
let niceSetMouseOffset (offsetX : int) (offsetY : int) = SetMouseOffset(offsetX, offsetY)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetMouseScale (float scaleX, float scaleY)
let niceSetMouseScale (scaleX : float) (scaleY : float) = SetMouseScale(scaleX, scaleY)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetMouseWheelMove ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetTouchX ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetTouchY ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Vector2 GetTouchPosition (int index)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetGesturesEnabled (uint32 gestureFlags)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsGestureDetected (int gesture)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetGestureDetected ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetTouchPointsCount ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern float GetGestureHoldDuration ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Vector2 GetGestureDragVector ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern float GetGestureDragAngle ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Vector2 GetGesturePinchVector ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern float GetGesturePinchAngle ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetCameraMode (Camera camera, int mode)
let niceSetCameraMode (camera : Camera) (mode : int) = SetCameraMode(camera, mode)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UpdateCamera (Camera[] camera)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetCameraPanControl (int panKey)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetCameraAltControl (int altKey)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetCameraSmoothZoomControl (int szKey)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetCameraMoveControls (int frontKey, int backKey, int rightKey, int leftKey, int upKey, int downKey)
let niceSetCameraMoveControls (frontKey : int) (backKey : int) (rightKey : int) (leftKey : int) (upKey : int) (downKey : int) = SetCameraMoveControls(frontKey, backKey, rightKey, leftKey, upKey, downKey)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawPixel (int posX, int posY, Color color)
let niceDrawPixel (posX : int) (posY : int) (color : Color) = DrawPixel(posX, posY, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawPixelV (Vector2 position, Color color)
let niceDrawPixelV (position : Vector2) (color : Color) = DrawPixelV(position, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawLine (int startPosX, int startPosY, int endPosX, int endPosY, Color color)
let niceDrawLine (startPosX : int) (startPosY : int) (endPosX : int) (endPosY : int) (color : Color) = DrawLine(startPosX, startPosY, endPosX, endPosY, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawLineV (Vector2 startPos, Vector2 endPos, Color color)
let niceDrawLineV (startPos : Vector2) (endPos : Vector2) (color : Color) = DrawLineV(startPos, endPos, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawLineEx (Vector2 startPos, Vector2 endPos, float thick, Color color)
let niceDrawLineEx (startPos : Vector2) (endPos : Vector2) (thick : float) (color : Color) = DrawLineEx(startPos, endPos, thick, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawLineBezier (Vector2 startPos, Vector2 endPos, float thick, Color color)
let niceDrawLineBezier (startPos : Vector2) (endPos : Vector2) (thick : float) (color : Color) = DrawLineBezier(startPos, endPos, thick, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawLineStrip (Vector2[] points, int numPoints, Color color)
let niceDrawLineStrip (points : Vector2[]) (numPoints : int) (color : Color) = DrawLineStrip(points, numPoints, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCircle (int centerX, int centerY, float radius, Color color)
let niceDrawCircle (centerX : int) (centerY : int) (radius : float) (color : Color) = DrawCircle(centerX, centerY, radius, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCircleSector (Vector2 center, float radius, int startAngle, int endAngle, int segments, Color color)
let niceDrawCircleSector (center : Vector2) (radius : float) (startAngle : int) (endAngle : int) (segments : int) (color : Color) = DrawCircleSector(center, radius, startAngle, endAngle, segments, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCircleSectorLines (Vector2 center, float radius, int startAngle, int endAngle, int segments, Color color)
let niceDrawCircleSectorLines (center : Vector2) (radius : float) (startAngle : int) (endAngle : int) (segments : int) (color : Color) = DrawCircleSectorLines(center, radius, startAngle, endAngle, segments, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCircleGradient (int centerX, int centerY, float radius, Color color1, Color color2)
let niceDrawCircleGradient (centerX : int) (centerY : int) (radius : float) (color1 : Color) (color2 : Color) = DrawCircleGradient(centerX, centerY, radius, color1, color2)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCircleV (Vector2 center, float radius, Color color)
let niceDrawCircleV (center : Vector2) (radius : float) (color : Color) = DrawCircleV(center, radius, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCircleLines (int centerX, int centerY, float radius, Color color)
let niceDrawCircleLines (centerX : int) (centerY : int) (radius : float) (color : Color) = DrawCircleLines(centerX, centerY, radius, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRing (Vector2 center, float innerRadius, float outerRadius, int startAngle, int endAngle, int segments, Color color)
let niceDrawRing (center : Vector2) (innerRadius : float) (outerRadius : float) (startAngle : int) (endAngle : int) (segments : int) (color : Color) = DrawRing(center, innerRadius, outerRadius, startAngle, endAngle, segments, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRingLines (Vector2 center, float innerRadius, float outerRadius, int startAngle, int endAngle, int segments, Color color)
let niceDrawRingLines (center : Vector2) (innerRadius : float) (outerRadius : float) (startAngle : int) (endAngle : int) (segments : int) (color : Color) = DrawRingLines(center, innerRadius, outerRadius, startAngle, endAngle, segments, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRectangle (int posX, int posY, int width, int height, Color color)
let niceDrawRectangle (posX : int) (posY : int) (width : int) (height : int) (color : Color) = DrawRectangle(posX, posY, width, height, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRectangleV (Vector2 position, Vector2 size, Color color)
let niceDrawRectangleV (position : Vector2) (size : Vector2) (color : Color) = DrawRectangleV(position, size, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRectangleRec (Rectangle rect, Color color)
let niceDrawRectangleRec (rect : Rectangle) (color : Color) = DrawRectangleRec(rect, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRectanglePro (Rectangle rect, Vector2 origin, float rotation, Color color)
let niceDrawRectanglePro (rect : Rectangle) (origin : Vector2) (rotation : float) (color : Color) = DrawRectanglePro(rect, origin, rotation, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRectangleGradientV (int posX, int posY, int width, int height, Color color1, Color color2)
let niceDrawRectangleGradientV (posX : int) (posY : int) (width : int) (height : int) (color1 : Color) (color2 : Color) = DrawRectangleGradientV(posX, posY, width, height, color1, color2)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRectangleGradientH (int posX, int posY, int width, int height, Color color1, Color color2)
let niceDrawRectangleGradientH (posX : int) (posY : int) (width : int) (height : int) (color1 : Color) (color2 : Color) = DrawRectangleGradientH(posX, posY, width, height, color1, color2)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRectangleGradientEx (Rectangle rect, Color col1, Color col2, Color col3, Color col4)
let niceDrawRectangleGradientEx (rect : Rectangle) (col1 : Color) (col2 : Color) (col3 : Color) (col4 : Color) = DrawRectangleGradientEx(rect, col1, col2, col3, col4)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRectangleLines (int posX, int posY, int width, int height, Color color)
let niceDrawRectangleLines (posX : int) (posY : int) (width : int) (height : int) (color : Color) = DrawRectangleLines(posX, posY, width, height, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRectangleLinesEx (Rectangle rect, int lineThick, Color color)
let niceDrawRectangleLinesEx (rect : Rectangle) (lineThick : int) (color : Color) = DrawRectangleLinesEx(rect, lineThick, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRectangleRounded (Rectangle rect, float roundness, int segments, Color color)
let niceDrawRectangleRounded (rect : Rectangle) (roundness : float) (segments : int) (color : Color) = DrawRectangleRounded(rect, roundness, segments, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRectangleRoundedLines (Rectangle rect, float roundness, int segments, int lineThick, Color color)
let niceDrawRectangleRoundedLines (rect : Rectangle) (roundness : float) (segments : int) (lineThick : int) (color : Color) = DrawRectangleRoundedLines(rect, roundness, segments, lineThick, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTriangle (Vector2 v1, Vector2 v2, Vector2 v3, Color color)
let niceDrawTriangle (v1 : Vector2) (v2 : Vector2) (v3 : Vector2) (color : Color) = DrawTriangle(v1, v2, v3, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTriangleLines (Vector2 v1, Vector2 v2, Vector2 v3, Color color)
let niceDrawTriangleLines (v1 : Vector2) (v2 : Vector2) (v3 : Vector2) (color : Color) = DrawTriangleLines(v1, v2, v3, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTriangleFan (Vector2[] points, int numPoints, Color color)
let niceDrawTriangleFan (points : Vector2[]) (numPoints : int) (color : Color) = DrawTriangleFan(points, numPoints, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTriangleStrip (Vector2[] points, int pointsCount, Color color)
let niceDrawTriangleStrip (points : Vector2[]) (pointsCount : int) (color : Color) = DrawTriangleStrip(points, pointsCount, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawPoly (Vector2 center, int sides, float radius, float rotation, Color color)
let niceDrawPoly (center : Vector2) (sides : int) (radius : float) (rotation : float) (color : Color) = DrawPoly(center, sides, radius, rotation, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetShapesTexture (Texture2D texture, Rectangle source)
let niceSetShapesTexture (texture : Texture2D) (source : Rectangle) = SetShapesTexture(texture, source)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool CheckCollisionRecs (Rectangle rec1, Rectangle rec2)
let niceCheckCollisionRecs (rec1 : Rectangle) (rec2 : Rectangle) = CheckCollisionRecs(rec1, rec2)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool CheckCollisionCircles (Vector2 center1, float radius1, Vector2 center2, float radius2)
let niceCheckCollisionCircles (center1 : Vector2) (radius1 : float) (center2 : Vector2) (radius2 : float) = CheckCollisionCircles(center1, radius1, center2, radius2)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool CheckCollisionCircleRec (Vector2 center, float radius, Rectangle rect)
let niceCheckCollisionCircleRec (center : Vector2) (radius : float) (rect : Rectangle) = CheckCollisionCircleRec(center, radius, rect)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Rectangle GetCollisionRec (Rectangle rec1, Rectangle rec2)
let niceGetCollisionRec (rec1 : Rectangle) (rec2 : Rectangle) = GetCollisionRec(rec1, rec2)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool CheckCollisionPointRec (Vector2 point, Rectangle rect)
let niceCheckCollisionPointRec (point : Vector2) (rect : Rectangle) = CheckCollisionPointRec(point, rect)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool CheckCollisionPointCircle (Vector2 point, Vector2 center, float radius)
let niceCheckCollisionPointCircle (point : Vector2) (center : Vector2) (radius : float) = CheckCollisionPointCircle(point, center, radius)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool CheckCollisionPointTriangle (Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3)
let niceCheckCollisionPointTriangle (point : Vector2) (p1 : Vector2) (p2 : Vector2) (p3 : Vector2) = CheckCollisionPointTriangle(point, p1, p2, p3)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image LoadImage (string fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image LoadImageEx (Color[] pixels, int width, int height)
let niceLoadImageEx (pixels : Color[]) (width : int) (height : int) = LoadImageEx(pixels, width, height)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image LoadImagePro (IntPtr data, int width, int height, int format)
let niceLoadImagePro (data : IntPtr) (width : int) (height : int) (format : int) = LoadImagePro(data, width, height, format)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image LoadImageRaw (string fileName, int width, int height, int format, int headerSize)
let niceLoadImageRaw (fileName : string) (width : int) (height : int) (format : int) (headerSize : int) = LoadImageRaw(fileName, width, height, format, headerSize)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ExportImage (Image image, string fileName)
let niceExportImage (image : Image) (fileName : string) = ExportImage(image, fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ExportImageAsCode (Image image, string fileName)
let niceExportImageAsCode (image : Image) (fileName : string) = ExportImageAsCode(image, fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Texture2D LoadTexture (string fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Texture2D LoadTextureFromImage (Image image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern TextureCubemap LoadTextureCubemap (Image image, int layoutType)
let niceLoadTextureCubemap (image : Image) (layoutType : int) = LoadTextureCubemap(image, layoutType)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern RenderTexture2D LoadRenderTexture (int width, int height)
let niceLoadRenderTexture (width : int) (height : int) = LoadRenderTexture(width, height)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnloadImage (Image image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnloadTexture (Texture2D texture)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnloadRenderTexture (RenderTexture2D target)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Color[] GetImageData (Image image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Vector4[] GetImageDataNormalized (Image image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Rectangle GetImageAlphaBorder (Image image, float threshold)
let niceGetImageAlphaBorder (image : Image) (threshold : float) = GetImageAlphaBorder(image, threshold)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetPixelDataSize (int width, int height, int format)
let niceGetPixelDataSize (width : int) (height : int) (format : int) = GetPixelDataSize(width, height, format)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image GetTextureData (Texture2D texture)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image GetScreenData ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UpdateTexture (Texture2D texture, const void[] pixels)
let niceUpdateTexture (texture : Texture2D) (pixels : const void[]) = UpdateTexture(texture, pixels)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image ImageCopy (Image image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image ImageFromImage (Image image, Rectangle rect)
let niceImageFromImage (image : Image) (rect : Rectangle) = ImageFromImage(image, rect)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageToPOT (Image[] image, Color fillColor)
let niceImageToPOT (image : Image[]) (fillColor : Color) = ImageToPOT(image, fillColor)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageFormat (Image[] image, int newFormat)
let niceImageFormat (image : Image[]) (newFormat : int) = ImageFormat(image, newFormat)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageAlphaMask (Image[] image, Image alphaMask)
let niceImageAlphaMask (image : Image[]) (alphaMask : Image) = ImageAlphaMask(image, alphaMask)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageAlphaClear (Image[] image, Color color, float threshold)
let niceImageAlphaClear (image : Image[]) (color : Color) (threshold : float) = ImageAlphaClear(image, color, threshold)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageAlphaCrop (Image[] image, float threshold)
let niceImageAlphaCrop (image : Image[]) (threshold : float) = ImageAlphaCrop(image, threshold)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageAlphaPremultiply (Image[] image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageCrop (Image[] image, Rectangle crop)
let niceImageCrop (image : Image[]) (crop : Rectangle) = ImageCrop(image, crop)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageResize (Image[] image, int newWidth, int newHeight)
let niceImageResize (image : Image[]) (newWidth : int) (newHeight : int) = ImageResize(image, newWidth, newHeight)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageResizeNN (Image[] image, int newWidth, int newHeight)
let niceImageResizeNN (image : Image[]) (newWidth : int) (newHeight : int) = ImageResizeNN(image, newWidth, newHeight)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageResizeCanvas (Image[] image, int newWidth, int newHeight, int offsetX, int offsetY, Color color)
let niceImageResizeCanvas (image : Image[]) (newWidth : int) (newHeight : int) (offsetX : int) (offsetY : int) (color : Color) = ImageResizeCanvas(image, newWidth, newHeight, offsetX, offsetY, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageMipmaps (Image[] image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageDither (Image[] image, int rBpp, int gBpp, int bBpp, int aBpp)
let niceImageDither (image : Image[]) (rBpp : int) (gBpp : int) (bBpp : int) (aBpp : int) = ImageDither(image, rBpp, gBpp, bBpp, aBpp)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Color[] ImageExtractPalette (Image image, int maxPaletteSize, int[] extractCount)
let niceImageExtractPalette (image : Image) (maxPaletteSize : int) (extractCount : int[]) = ImageExtractPalette(image, maxPaletteSize, extractCount)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image ImageText (string text, int fontSize, Color color)
let niceImageText (text : string) (fontSize : int) (color : Color) = ImageText(text, fontSize, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image ImageTextEx (Font font, string text, float fontSize, float spacing, Color tint)
let niceImageTextEx (font : Font) (text : string) (fontSize : float) (spacing : float) (tint : Color) = ImageTextEx(font, text, fontSize, spacing, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageDraw (Image[] dst, Image src, Rectangle srcRec, Rectangle dstRec, Color tint)
let niceImageDraw (dst : Image[]) (src : Image) (srcRec : Rectangle) (dstRec : Rectangle) (tint : Color) = ImageDraw(dst, src, srcRec, dstRec, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageDrawRectangle (Image[] dst, Rectangle rect, Color color)
let niceImageDrawRectangle (dst : Image[]) (rect : Rectangle) (color : Color) = ImageDrawRectangle(dst, rect, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageDrawRectangleLines (Image[] dst, Rectangle rect, int thick, Color color)
let niceImageDrawRectangleLines (dst : Image[]) (rect : Rectangle) (thick : int) (color : Color) = ImageDrawRectangleLines(dst, rect, thick, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageDrawText (Image[] dst, Vector2 position, string text, int fontSize, Color color)
let niceImageDrawText (dst : Image[]) (position : Vector2) (text : string) (fontSize : int) (color : Color) = ImageDrawText(dst, position, text, fontSize, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageDrawTextEx (Image[] dst, Vector2 position, Font font, string text, float fontSize, float spacing, Color color)
let niceImageDrawTextEx (dst : Image[]) (position : Vector2) (font : Font) (text : string) (fontSize : float) (spacing : float) (color : Color) = ImageDrawTextEx(dst, position, font, text, fontSize, spacing, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageFlipVertical (Image[] image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageFlipHorizontal (Image[] image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageRotateCW (Image[] image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageRotateCCW (Image[] image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageColorTint (Image[] image, Color color)
let niceImageColorTint (image : Image[]) (color : Color) = ImageColorTint(image, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageColorInvert (Image[] image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageColorGrayscale (Image[] image)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageColorContrast (Image[] image, float contrast)
let niceImageColorContrast (image : Image[]) (contrast : float) = ImageColorContrast(image, contrast)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageColorBrightness (Image[] image, int brightness)
let niceImageColorBrightness (image : Image[]) (brightness : int) = ImageColorBrightness(image, brightness)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ImageColorReplace (Image[] image, Color color, Color replace)
let niceImageColorReplace (image : Image[]) (color : Color) (replace : Color) = ImageColorReplace(image, color, replace)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image GenImageColor (int width, int height, Color color)
let niceGenImageColor (width : int) (height : int) (color : Color) = GenImageColor(width, height, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image GenImageGradientV (int width, int height, Color top, Color bottom)
let niceGenImageGradientV (width : int) (height : int) (top : Color) (bottom : Color) = GenImageGradientV(width, height, top, bottom)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image GenImageGradientH (int width, int height, Color left, Color right)
let niceGenImageGradientH (width : int) (height : int) (left : Color) (right : Color) = GenImageGradientH(width, height, left, right)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image GenImageGradientRadial (int width, int height, float density, Color inner, Color outer)
let niceGenImageGradientRadial (width : int) (height : int) (density : float) (inner : Color) (outer : Color) = GenImageGradientRadial(width, height, density, inner, outer)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image GenImageChecked (int width, int height, int checksX, int checksY, Color col1, Color col2)
let niceGenImageChecked (width : int) (height : int) (checksX : int) (checksY : int) (col1 : Color) (col2 : Color) = GenImageChecked(width, height, checksX, checksY, col1, col2)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image GenImageWhiteNoise (int width, int height, float factor)
let niceGenImageWhiteNoise (width : int) (height : int) (factor : float) = GenImageWhiteNoise(width, height, factor)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image GenImagePerlinNoise (int width, int height, int offsetX, int offsetY, float scale)
let niceGenImagePerlinNoise (width : int) (height : int) (offsetX : int) (offsetY : int) (scale : float) = GenImagePerlinNoise(width, height, offsetX, offsetY, scale)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image GenImageCellular (int width, int height, int tileSize)
let niceGenImageCellular (width : int) (height : int) (tileSize : int) = GenImageCellular(width, height, tileSize)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void GenTextureMipmaps (Texture2D[] texture)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetTextureFilter (Texture2D texture, int filterMode)
let niceSetTextureFilter (texture : Texture2D) (filterMode : int) = SetTextureFilter(texture, filterMode)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetTextureWrap (Texture2D texture, int wrapMode)
let niceSetTextureWrap (texture : Texture2D) (wrapMode : int) = SetTextureWrap(texture, wrapMode)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTexture (Texture2D texture, int posX, int posY, Color tint)
let niceDrawTexture (texture : Texture2D) (posX : int) (posY : int) (tint : Color) = DrawTexture(texture, posX, posY, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTextureV (Texture2D texture, Vector2 position, Color tint)
let niceDrawTextureV (texture : Texture2D) (position : Vector2) (tint : Color) = DrawTextureV(texture, position, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTextureEx (Texture2D texture, Vector2 position, float rotation, float scale, Color tint)
let niceDrawTextureEx (texture : Texture2D) (position : Vector2) (rotation : float) (scale : float) (tint : Color) = DrawTextureEx(texture, position, rotation, scale, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTextureRec (Texture2D texture, Rectangle sourceRec, Vector2 position, Color tint)
let niceDrawTextureRec (texture : Texture2D) (sourceRec : Rectangle) (position : Vector2) (tint : Color) = DrawTextureRec(texture, sourceRec, position, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTextureQuad (Texture2D texture, Vector2 tiling, Vector2 offset, Rectangle quad, Color tint)
let niceDrawTextureQuad (texture : Texture2D) (tiling : Vector2) (offset : Vector2) (quad : Rectangle) (tint : Color) = DrawTextureQuad(texture, tiling, offset, quad, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTexturePro (Texture2D texture, Rectangle sourceRec, Rectangle destRec, Vector2 origin, float rotation, Color tint)
let niceDrawTexturePro (texture : Texture2D) (sourceRec : Rectangle) (destRec : Rectangle) (origin : Vector2) (rotation : float) (tint : Color) = DrawTexturePro(texture, sourceRec, destRec, origin, rotation, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTextureNPatch (Texture2D texture, NPatchInfo nPatchInfo, Rectangle destRec, Vector2 origin, float rotation, Color tint)
let niceDrawTextureNPatch (texture : Texture2D) (nPatchInfo : NPatchInfo) (destRec : Rectangle) (origin : Vector2) (rotation : float) (tint : Color) = DrawTextureNPatch(texture, nPatchInfo, destRec, origin, rotation, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Font GetFontDefault ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Font LoadFont (string fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Font LoadFontEx (string fileName, int fontSize, int[] fontChars, int charsCount)
let niceLoadFontEx (fileName : string) (fontSize : int) (fontChars : int[]) (charsCount : int) = LoadFontEx(fileName, fontSize, fontChars, charsCount)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Font LoadFontFromImage (Image image, Color key, int firstChar)
let niceLoadFontFromImage (image : Image) (key : Color) (firstChar : int) = LoadFontFromImage(image, key, firstChar)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern CharInfo[] LoadFontData (string fileName, int fontSize, int[] fontChars, int charsCount, int type)
let niceLoadFontData (fileName : string) (fontSize : int) (fontChars : int[]) (charsCount : int) (type : int) = LoadFontData(fileName, fontSize, fontChars, charsCount, type)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Image GenImageFontAtlas (const CharInfo[] chars, Rectangle[][] recs, int charsCount, int fontSize, int padding, int packMethod)
let niceGenImageFontAtlas (chars : const CharInfo[]) (recs : Rectangle[][]) (charsCount : int) (fontSize : int) (padding : int) (packMethod : int) = GenImageFontAtlas(chars, recs, charsCount, fontSize, padding, packMethod)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnloadFont (Font font)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawFPS (int posX, int posY)
let niceDrawFPS (posX : int) (posY : int) = DrawFPS(posX, posY)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawText (string text, int posX, int posY, int fontSize, Color color)
let niceDrawText (text : string) (posX : int) (posY : int) (fontSize : int) (color : Color) = DrawText(text, posX, posY, fontSize, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTextEx (Font font, string text, Vector2 position, float fontSize, float spacing, Color tint)
let niceDrawTextEx (font : Font) (text : string) (position : Vector2) (fontSize : float) (spacing : float) (tint : Color) = DrawTextEx(font, text, position, fontSize, spacing, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTextRec (Font font, string text, Rectangle rect, float fontSize, float spacing, bool wordWrap, Color tint)
let niceDrawTextRec (font : Font) (text : string) (rect : Rectangle) (fontSize : float) (spacing : float) (wordWrap : bool) (tint : Color) = DrawTextRec(font, text, rect, fontSize, spacing, wordWrap, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawTextRecEx (Font font, string text, Rectangle rect, float fontSize, float spacing, bool wordWrap, Color tint, int selectStart, int selectLength, Color selectText, Color selectBack)
let niceDrawTextRecEx (font : Font) (text : string) (rect : Rectangle) (fontSize : float) (spacing : float) (wordWrap : bool) (tint : Color) (selectStart : int) (selectLength : int) (selectText : Color) (selectBack : Color) = DrawTextRecEx(font, text, rect, fontSize, spacing, wordWrap, tint, selectStart, selectLength, selectText, selectBack)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int MeasureText (string text, int fontSize)
let niceMeasureText (text : string) (fontSize : int) = MeasureText(text, fontSize)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Vector2 MeasureTextEx (Font font, string text, float fontSize, float spacing)
let niceMeasureTextEx (font : Font) (text : string) (fontSize : float) (spacing : float) = MeasureTextEx(font, text, fontSize, spacing)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetGlyphIndex (Font font, int character)
let niceGetGlyphIndex (font : Font) (character : int) = GetGlyphIndex(font, character)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetNextCodepoint (string text, int[] bytesProcessed)
let niceGetNextCodepoint (text : string) (bytesProcessed : int[]) = GetNextCodepoint(text, bytesProcessed)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int[] GetCodepoints (string text, int[] count)
let niceGetCodepoints (text : string) (count : int[]) = GetCodepoints(text, count)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool TextIsEqual (string text1, string text2)
let niceTextIsEqual (text1 : string) (text2 : string) = TextIsEqual(text1, text2)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern uint32 TextLength (string text)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern uint32 TextCountCodepoints (string text)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string TextFormat (string text)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string TextSubtext (string text, int position, int length)
let niceTextSubtext (text : string) (position : int) (length : int) = TextSubtext(text, position, length)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern char[] TextReplace (char[] text, string replace, string by)
let niceTextReplace (text : char[]) (replace : string) (by : string) = TextReplace(text, replace, by)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern char[] TextInsert (string text, string insert, int position)
let niceTextInsert (text : string) (insert : string) (position : int) = TextInsert(text, insert, position)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string TextJoin (const char[][] textList, int count, string delimiter)
let niceTextJoin (textList : const char[][]) (count : int) (delimiter : string) = TextJoin(textList, count, delimiter)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern const char[][] TextSplit (string text, char delimiter, int[] count)
let niceTextSplit (text : string) (delimiter : char) (count : int[]) = TextSplit(text, delimiter, count)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void TextAppend (char[] text, string append, int[] position)
let niceTextAppend (text : char[]) (append : string) (position : int[]) = TextAppend(text, append, position)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int TextFindIndex (string text, string find)
let niceTextFindIndex (text : string) (find : string) = TextFindIndex(text, find)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string TextToUpper (string text)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string TextToLower (string text)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern string TextToPascal (string text)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int TextToInteger (string text)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawLine3D (Vector3 startPos, Vector3 endPos, Color color)
let niceDrawLine3D (startPos : Vector3) (endPos : Vector3) (color : Color) = DrawLine3D(startPos, endPos, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCircle3D (Vector3 center, float radius, Vector3 rotationAxis, float rotationAngle, Color color)
let niceDrawCircle3D (center : Vector3) (radius : float) (rotationAxis : Vector3) (rotationAngle : float) (color : Color) = DrawCircle3D(center, radius, rotationAxis, rotationAngle, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCube (Vector3 position, float width, float height, float length, Color color)
let niceDrawCube (position : Vector3) (width : float) (height : float) (length : float) (color : Color) = DrawCube(position, width, height, length, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCubeV (Vector3 position, Vector3 size, Color color)
let niceDrawCubeV (position : Vector3) (size : Vector3) (color : Color) = DrawCubeV(position, size, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCubeWires (Vector3 position, float width, float height, float length, Color color)
let niceDrawCubeWires (position : Vector3) (width : float) (height : float) (length : float) (color : Color) = DrawCubeWires(position, width, height, length, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCubeWiresV (Vector3 position, Vector3 size, Color color)
let niceDrawCubeWiresV (position : Vector3) (size : Vector3) (color : Color) = DrawCubeWiresV(position, size, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCubeTexture (Texture2D texture, Vector3 position, float width, float height, float length, Color color)
let niceDrawCubeTexture (texture : Texture2D) (position : Vector3) (width : float) (height : float) (length : float) (color : Color) = DrawCubeTexture(texture, position, width, height, length, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawSphere (Vector3 centerPos, float radius, Color color)
let niceDrawSphere (centerPos : Vector3) (radius : float) (color : Color) = DrawSphere(centerPos, radius, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawSphereEx (Vector3 centerPos, float radius, int rings, int slices, Color color)
let niceDrawSphereEx (centerPos : Vector3) (radius : float) (rings : int) (slices : int) (color : Color) = DrawSphereEx(centerPos, radius, rings, slices, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawSphereWires (Vector3 centerPos, float radius, int rings, int slices, Color color)
let niceDrawSphereWires (centerPos : Vector3) (radius : float) (rings : int) (slices : int) (color : Color) = DrawSphereWires(centerPos, radius, rings, slices, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCylinder (Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color)
let niceDrawCylinder (position : Vector3) (radiusTop : float) (radiusBottom : float) (height : float) (slices : int) (color : Color) = DrawCylinder(position, radiusTop, radiusBottom, height, slices, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawCylinderWires (Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color)
let niceDrawCylinderWires (position : Vector3) (radiusTop : float) (radiusBottom : float) (height : float) (slices : int) (color : Color) = DrawCylinderWires(position, radiusTop, radiusBottom, height, slices, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawPlane (Vector3 centerPos, Vector2 size, Color color)
let niceDrawPlane (centerPos : Vector3) (size : Vector2) (color : Color) = DrawPlane(centerPos, size, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawRay (Ray ray, Color color)
let niceDrawRay (ray : Ray) (color : Color) = DrawRay(ray, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawGrid (int slices, float spacing)
let niceDrawGrid (slices : int) (spacing : float) = DrawGrid(slices, spacing)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawGizmo (Vector3 position)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Model LoadModel (string fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Model LoadModelFromMesh (Mesh mesh)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnloadModel (Model model)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Mesh[] LoadMeshes (string fileName, int[] meshCount)
let niceLoadMeshes (fileName : string) (meshCount : int[]) = LoadMeshes(fileName, meshCount)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ExportMesh (Mesh mesh, string fileName)
let niceExportMesh (mesh : Mesh) (fileName : string) = ExportMesh(mesh, fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnloadMesh (Mesh mesh)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Material[] LoadMaterials (string fileName, int[] materialCount)
let niceLoadMaterials (fileName : string) (materialCount : int[]) = LoadMaterials(fileName, materialCount)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Material LoadMaterialDefault ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnloadMaterial (Material material)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetMaterialTexture (Material[] material, int mapType, Texture2D texture)
let niceSetMaterialTexture (material : Material[]) (mapType : int) (texture : Texture2D) = SetMaterialTexture(material, mapType, texture)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetModelMeshMaterial (Model[] model, int meshId, int materialId)
let niceSetModelMeshMaterial (model : Model[]) (meshId : int) (materialId : int) = SetModelMeshMaterial(model, meshId, materialId)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern ModelAnimation[] LoadModelAnimations (string fileName, int[] animsCount)
let niceLoadModelAnimations (fileName : string) (animsCount : int[]) = LoadModelAnimations(fileName, animsCount)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UpdateModelAnimation (Model model, ModelAnimation anim, int frame)
let niceUpdateModelAnimation (model : Model) (anim : ModelAnimation) (frame : int) = UpdateModelAnimation(model, anim, frame)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnloadModelAnimation (ModelAnimation anim)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsModelAnimationValid (Model model, ModelAnimation anim)
let niceIsModelAnimationValid (model : Model) (anim : ModelAnimation) = IsModelAnimationValid(model, anim)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Mesh GenMeshPoly (int sides, float radius)
let niceGenMeshPoly (sides : int) (radius : float) = GenMeshPoly(sides, radius)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Mesh GenMeshPlane (float width, float length, int resX, int resZ)
let niceGenMeshPlane (width : float) (length : float) (resX : int) (resZ : int) = GenMeshPlane(width, length, resX, resZ)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Mesh GenMeshCube (float width, float height, float length)
let niceGenMeshCube (width : float) (height : float) (length : float) = GenMeshCube(width, height, length)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Mesh GenMeshSphere (float radius, int rings, int slices)
let niceGenMeshSphere (radius : float) (rings : int) (slices : int) = GenMeshSphere(radius, rings, slices)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Mesh GenMeshHemiSphere (float radius, int rings, int slices)
let niceGenMeshHemiSphere (radius : float) (rings : int) (slices : int) = GenMeshHemiSphere(radius, rings, slices)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Mesh GenMeshCylinder (float radius, float height, int slices)
let niceGenMeshCylinder (radius : float) (height : float) (slices : int) = GenMeshCylinder(radius, height, slices)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Mesh GenMeshTorus (float radius, float size, int radSeg, int sides)
let niceGenMeshTorus (radius : float) (size : float) (radSeg : int) (sides : int) = GenMeshTorus(radius, size, radSeg, sides)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Mesh GenMeshKnot (float radius, float size, int radSeg, int sides)
let niceGenMeshKnot (radius : float) (size : float) (radSeg : int) (sides : int) = GenMeshKnot(radius, size, radSeg, sides)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Mesh GenMeshHeightmap (Image heightmap, Vector3 size)
let niceGenMeshHeightmap (heightmap : Image) (size : Vector3) = GenMeshHeightmap(heightmap, size)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Mesh GenMeshCubicmap (Image cubicmap, Vector3 cubeSize)
let niceGenMeshCubicmap (cubicmap : Image) (cubeSize : Vector3) = GenMeshCubicmap(cubicmap, cubeSize)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern BoundingBox MeshBoundingBox (Mesh mesh)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void MeshTangents (Mesh[] mesh)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void MeshBinormals (Mesh[] mesh)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawModel (Model model, Vector3 position, float scale, Color tint)
let niceDrawModel (model : Model) (position : Vector3) (scale : float) (tint : Color) = DrawModel(model, position, scale, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawModelEx (Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint)
let niceDrawModelEx (model : Model) (position : Vector3) (rotationAxis : Vector3) (rotationAngle : float) (scale : Vector3) (tint : Color) = DrawModelEx(model, position, rotationAxis, rotationAngle, scale, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawModelWires (Model model, Vector3 position, float scale, Color tint)
let niceDrawModelWires (model : Model) (position : Vector3) (scale : float) (tint : Color) = DrawModelWires(model, position, scale, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawModelWiresEx (Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint)
let niceDrawModelWiresEx (model : Model) (position : Vector3) (rotationAxis : Vector3) (rotationAngle : float) (scale : Vector3) (tint : Color) = DrawModelWiresEx(model, position, rotationAxis, rotationAngle, scale, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawBoundingBox (BoundingBox box, Color color)
let niceDrawBoundingBox (box : BoundingBox) (color : Color) = DrawBoundingBox(box, color)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawBillboard (Camera camera, Texture2D texture, Vector3 center, float size, Color tint)
let niceDrawBillboard (camera : Camera) (texture : Texture2D) (center : Vector3) (size : float) (tint : Color) = DrawBillboard(camera, texture, center, size, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void DrawBillboardRec (Camera camera, Texture2D texture, Rectangle sourceRec, Vector3 center, float size, Color tint)
let niceDrawBillboardRec (camera : Camera) (texture : Texture2D) (sourceRec : Rectangle) (center : Vector3) (size : float) (tint : Color) = DrawBillboardRec(camera, texture, sourceRec, center, size, tint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool CheckCollisionSpheres (Vector3 centerA, float radiusA, Vector3 centerB, float radiusB)
let niceCheckCollisionSpheres (centerA : Vector3) (radiusA : float) (centerB : Vector3) (radiusB : float) = CheckCollisionSpheres(centerA, radiusA, centerB, radiusB)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool CheckCollisionBoxes (BoundingBox box1, BoundingBox box2)
let niceCheckCollisionBoxes (box1 : BoundingBox) (box2 : BoundingBox) = CheckCollisionBoxes(box1, box2)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool CheckCollisionBoxSphere (BoundingBox box, Vector3 center, float radius)
let niceCheckCollisionBoxSphere (box : BoundingBox) (center : Vector3) (radius : float) = CheckCollisionBoxSphere(box, center, radius)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool CheckCollisionRaySphere (Ray ray, Vector3 center, float radius)
let niceCheckCollisionRaySphere (ray : Ray) (center : Vector3) (radius : float) = CheckCollisionRaySphere(ray, center, radius)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool CheckCollisionRaySphereEx (Ray ray, Vector3 center, float radius, Vector3[] collisionPoint)
let niceCheckCollisionRaySphereEx (ray : Ray) (center : Vector3) (radius : float) (collisionPoint : Vector3[]) = CheckCollisionRaySphereEx(ray, center, radius, collisionPoint)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool CheckCollisionRayBox (Ray ray, BoundingBox box)
let niceCheckCollisionRayBox (ray : Ray) (box : BoundingBox) = CheckCollisionRayBox(ray, box)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern RayHitInfo GetCollisionRayModel (Ray ray, Model model)
let niceGetCollisionRayModel (ray : Ray) (model : Model) = GetCollisionRayModel(ray, model)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern RayHitInfo GetCollisionRayTriangle (Ray ray, Vector3 p1, Vector3 p2, Vector3 p3)
let niceGetCollisionRayTriangle (ray : Ray) (p1 : Vector3) (p2 : Vector3) (p3 : Vector3) = GetCollisionRayTriangle(ray, p1, p2, p3)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern RayHitInfo GetCollisionRayGround (Ray ray, float groundHeight)
let niceGetCollisionRayGround (ray : Ray) (groundHeight : float) = GetCollisionRayGround(ray, groundHeight)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern char[] LoadText (string fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Shader LoadShader (string vsFileName, string fsFileName)
let niceLoadShader (vsFileName : string) (fsFileName : string) = LoadShader(vsFileName, fsFileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Shader LoadShaderCode (string vsCode, string fsCode)
let niceLoadShaderCode (vsCode : string) (fsCode : string) = LoadShaderCode(vsCode, fsCode)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnloadShader (Shader shader)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Shader GetShaderDefault ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Texture2D GetTextureDefault ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetShaderLocation (Shader shader, string uniformName)
let niceGetShaderLocation (shader : Shader) (uniformName : string) = GetShaderLocation(shader, uniformName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetShaderValue (Shader shader, int uniformLoc, const void[] value, int uniformType)
let niceSetShaderValue (shader : Shader) (uniformLoc : int) (value : const void[]) (uniformType : int) = SetShaderValue(shader, uniformLoc, value, uniformType)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetShaderValueV (Shader shader, int uniformLoc, const void[] value, int uniformType, int count)
let niceSetShaderValueV (shader : Shader) (uniformLoc : int) (value : const void[]) (uniformType : int) (count : int) = SetShaderValueV(shader, uniformLoc, value, uniformType, count)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetShaderValueMatrix (Shader shader, int uniformLoc, Matrix mat)
let niceSetShaderValueMatrix (shader : Shader) (uniformLoc : int) (mat : Matrix) = SetShaderValueMatrix(shader, uniformLoc, mat)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetShaderValueTexture (Shader shader, int uniformLoc, Texture2D texture)
let niceSetShaderValueTexture (shader : Shader) (uniformLoc : int) (texture : Texture2D) = SetShaderValueTexture(shader, uniformLoc, texture)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetMatrixProjection (Matrix proj)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetMatrixModelview (Matrix view)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Matrix GetMatrixModelview ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Texture2D GenTextureCubemap (Shader shader, Texture2D skyHDR, int size)
let niceGenTextureCubemap (shader : Shader) (skyHDR : Texture2D) (size : int) = GenTextureCubemap(shader, skyHDR, size)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Texture2D GenTextureIrradiance (Shader shader, Texture2D cubemap, int size)
let niceGenTextureIrradiance (shader : Shader) (cubemap : Texture2D) (size : int) = GenTextureIrradiance(shader, cubemap, size)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Texture2D GenTexturePrefilter (Shader shader, Texture2D cubemap, int size)
let niceGenTexturePrefilter (shader : Shader) (cubemap : Texture2D) (size : int) = GenTexturePrefilter(shader, cubemap, size)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Texture2D GenTextureBRDF (Shader shader, int size)
let niceGenTextureBRDF (shader : Shader) (size : int) = GenTextureBRDF(shader, size)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void BeginShaderMode (Shader shader)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void EndShaderMode ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void BeginBlendMode (int mode)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void EndBlendMode ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void InitVrSimulator ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void CloseVrSimulator ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UpdateVrTracking (Camera[] camera)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetVrConfiguration (VrDeviceInfo info, Shader distortion)
let niceSetVrConfiguration (info : VrDeviceInfo) (distortion : Shader) = SetVrConfiguration(info, distortion)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsVrSimulatorReady ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ToggleVrMode ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void BeginVrDrawing ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void EndVrDrawing ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void InitAudioDevice ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void CloseAudioDevice ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsAudioDeviceReady ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetMasterVolume (float volume)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Wave LoadWave (string fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Sound LoadSound (string fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Sound LoadSoundFromWave (Wave wave)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UpdateSound (Sound sound, const void[] data, int samplesCount)
let niceUpdateSound (sound : Sound) (data : const void[]) (samplesCount : int) = UpdateSound(sound, data, samplesCount)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnloadWave (Wave wave)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnloadSound (Sound sound)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ExportWave (Wave wave, string fileName)
let niceExportWave (wave : Wave) (fileName : string) = ExportWave(wave, fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ExportWaveAsCode (Wave wave, string fileName)
let niceExportWaveAsCode (wave : Wave) (fileName : string) = ExportWaveAsCode(wave, fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void PlaySound (Sound sound)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void StopSound (Sound sound)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void PauseSound (Sound sound)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ResumeSound (Sound sound)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void PlaySoundMulti (Sound sound)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void StopSoundMulti ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern int GetSoundsPlaying ()
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsSoundPlaying (Sound sound)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetSoundVolume (Sound sound, float volume)
let niceSetSoundVolume (sound : Sound) (volume : float) = SetSoundVolume(sound, volume)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetSoundPitch (Sound sound, float pitch)
let niceSetSoundPitch (sound : Sound) (pitch : float) = SetSoundPitch(sound, pitch)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void WaveFormat (Wave[] wave, int sampleRate, int sampleSize, int channels)
let niceWaveFormat (wave : Wave[]) (sampleRate : int) (sampleSize : int) (channels : int) = WaveFormat(wave, sampleRate, sampleSize, channels)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Wave WaveCopy (Wave wave)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void WaveCrop (Wave[] wave, int initSample, int finalSample)
let niceWaveCrop (wave : Wave[]) (initSample : int) (finalSample : int) = WaveCrop(wave, initSample, finalSample)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern float[] GetWaveData (Wave wave)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern Music LoadMusicStream (string fileName)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UnloadMusicStream (Music music)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void PlayMusicStream (Music music)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UpdateMusicStream (Music music)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void StopMusicStream (Music music)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void PauseMusicStream (Music music)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ResumeMusicStream (Music music)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsMusicPlaying (Music music)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetMusicVolume (Music music, float volume)
let niceSetMusicVolume (music : Music) (volume : float) = SetMusicVolume(music, volume)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetMusicPitch (Music music, float pitch)
let niceSetMusicPitch (music : Music) (pitch : float) = SetMusicPitch(music, pitch)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetMusicLoopCount (Music music, int count)
let niceSetMusicLoopCount (music : Music) (count : int) = SetMusicLoopCount(music, count)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern float GetMusicTimeLength (Music music)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern float GetMusicTimePlayed (Music music)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern AudioStream InitAudioStream (uint32 sampleRate, uint32 sampleSize, uint32 channels)
let niceInitAudioStream (sampleRate : uint32) (sampleSize : uint32) (channels : uint32) = InitAudioStream(sampleRate, sampleSize, channels)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void UpdateAudioStream (AudioStream stream, const void[] data, int samplesCount)
let niceUpdateAudioStream (stream : AudioStream) (data : const void[]) (samplesCount : int) = UpdateAudioStream(stream, data, samplesCount)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void CloseAudioStream (AudioStream stream)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsAudioStreamProcessed (AudioStream stream)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void PlayAudioStream (AudioStream stream)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void PauseAudioStream (AudioStream stream)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void ResumeAudioStream (AudioStream stream)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern bool IsAudioStreamPlaying (AudioStream stream)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void StopAudioStream (AudioStream stream)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetAudioStreamVolume (AudioStream stream, float volume)
let niceSetAudioStreamVolume (stream : AudioStream) (volume : float) = SetAudioStreamVolume(stream, volume)
[<DllImport("Assembly name here", CallingConvention = CallingConvention.Cdecl)>]
extern void SetAudioStreamPitch (AudioStream stream, float pitch)
let niceSetAudioStreamPitch (stream : AudioStream) (pitch : float) = SetAudioStreamPitch(stream, pitch)
